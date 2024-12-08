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
using MQTTConnectModule;

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
            var client = new HttpClient();

            // API URI
            string uri = "https://localhost:7093/api/authentication/login";

            // API KEY
            var apiKey = Environment.GetEnvironmentVariable("API_KEY");

            //Api key header içersine eklenir.
            client.DefaultRequestHeaders.Add("x-api-key", apiKey);

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
                HttpResponseMessage response = await client.PostAsync(uri, content);

                // Cevap başarılıysa buraya gelir
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    MQTTConnectionHandler.Instance.ConfigureConnection("127.0.0.1", responseBody, apiKey);
                    await MQTTConnectionHandler.Instance.ConnectToMQTTServerAsync();

                    // Gelen body içerisinde jwt token bulunmakta, sisteme bu token kaydedilir.
                    AuthenticationManager.Instance.SetUserAuthenticationToken(responseBody);

                    UpdateStatusLabel("Giriş Başarılı", true);

                    //Ana uygulama formu açılır
                    var appForm = new MainApplicationForm();
                    appForm.Show();

                    //Giriş yapma formu kapanır
                    this.Hide();
                }
                else
                {
                    UpdateStatusLabel($"Hata: {response.StatusCode}", false);
                }
            }
            catch (Exception ex)
            {
                UpdateStatusLabel($"Bir hata oluştu: {ex.Message}", false);
            }

            client.Dispose();
        }


        private async void RegisterButtonClicked(object sender, EventArgs e)
        {
            var client = new HttpClient();

            // API URL
            string url = "https://localhost:7093/api/authentication";

            // API KEY
            var apiKey = Environment.GetEnvironmentVariable("API_KEY");

            //Api key header içersine eklenir.
            client.DefaultRequestHeaders.Add("x-api-key", apiKey);

            //Registiration verisi
            var registerData = new
            {
                userName = userNameBox.Text,
                password = passwordBox.Text,
                email = "",
                phoneNumber = "",
                roles = new[] { "User" }
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
                var response = await client.PostAsync(url, jsonContent);

                if (response.IsSuccessStatusCode)
                    UpdateStatusLabel("Kayıt başarılı", true);
                else
                    UpdateStatusLabel("Kayıt Başarısız, Status : "
                        + response.StatusCode + " , error: " +
                        await response.Content.ReadAsStringAsync(), false);
            }
            catch (Exception ex)
            {
                UpdateStatusLabel("Bir sorun oluştu : " + ex.Message, false);
            }

            client.Dispose();
        }
        private void UpdateStatusLabel(string message,bool success)
        {
            var color = success ? Color.Green : Color.Red;

            authStatusLabel.ForeColor = color;
            authStatusLabel.Text = message;
        }
    }
}
