using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using FileTransferAppClient.Managers;
using System.Text;
using Newtonsoft.Json;
using DotNetEnv;
using System.IO;
using System.Diagnostics;
using System.Drawing;


namespace FileTransferAppClient
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();

            //Ortam değişkenleri dosyası bulunur ve yüklenir.
            var projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var envFilePath = Path.Combine(projectDirectory, "variables.env");
            Env.Load(envFilePath);
        }

        /*  Giriş yapma butonuna basıldığında çalışır.
         *  API'ye https isteği gönderir, kullanıcı eğer bulunursa giriş yapılır.
         *  Kullanıcı bulunamazsa errror yazısı açılır ve yazı güncellenir.
         */
        private async void LoginButtonClicked(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                // API URL
                string url = "https://localhost:7093/api/authentication/login";

                // Kullanıcı adı ve şifreyi içeren JSON objesi
                var loginData = new
                {
                    userName = userNameBox.Text, // Kullanıcı adı (burada örnek bir değer verdim)
                    password = passwordBox.Text  // Şifre (burada örnek bir değer verdim)
                };

                try
                {
                    // JSON veriyi içeren POST isteği gönder
                    var content = new StringContent(JsonConvert.SerializeObject(loginData), Encoding.UTF8, "application/json");

                    // POST isteği gönder
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    // Cevap başarılıysa buraya gelir
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Gelen body içerisinde jwt token bulunmakta, sisteme bu token kaydedilir.
                        AuthenticationManager.Instance.SetUserAuthenticationToken(responseBody);

                        authErrorLabel.ForeColor = Color.Green;
                        authErrorLabel.Text = "Giriş Başarılı";
                    }
                    else
                    {
                        authErrorLabel.ForeColor = Color.Red;
                        authErrorLabel.Text = $"Hata: {response.StatusCode}";
                    }
                }
                catch (Exception ex)
                {
                    authErrorLabel.ForeColor = Color.Red;
                    authErrorLabel.Text = $"Bir hata oluştu: {ex.Message}";
                }
            }
        }


        private async void RegisterButtonClicked(object sender, EventArgs e)
        {

            var apiKey = Environment.GetEnvironmentVariable("API_KEY");

            using (HttpClient  httpClient = new HttpClient())
            {
                // API URL
                string url = "https://localhost:7093/api/authentication";

                //Api key header içersine eklenir.
                httpClient.DefaultRequestHeaders.Add("x-api-key", apiKey);

                //Registiration verisi
                var registerData = new
                {
                    userName = userNameBox.Text,
                    password = passwordBox.Text,
                    email = "",
                    phoneNumber = "",
                    roles = new[] {"User"}
                };

                try
                {
                    //Gidecek json dosyası serialize edilir
                    var jsonContent = new StringContent(
                        JsonConvert.SerializeObject(registerData),
                        System.Text.Encoding.UTF8,
                        "application/json"
                        );

                    //Request gönderilir ve response alınır.
                    var response = await httpClient.PostAsync(url, jsonContent);

                    if (response.IsSuccessStatusCode)
                    {
                        authErrorLabel.ForeColor = Color.Green;
                        authErrorLabel.Text = "Kayıt başarılı";
                    }
                    else
                    {
                        authErrorLabel.ForeColor = Color.Red;
                        authErrorLabel.Text = "Kayıt Başarısız, Status : "
                            + response.StatusCode + " , error: " + 
                            await response.Content.ReadAsStringAsync();
                    }
                }
                catch (Exception ex)
                {
                    authErrorLabel.ForeColor = Color.Red;
                    authErrorLabel.Text = "Bir sorun oluştu : " + ex.Message;
                }
            }
        }
    }
}
