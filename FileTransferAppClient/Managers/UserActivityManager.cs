using FileTransferAppClient.Models;
using FileTransferAppClient.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTransferAppClient.Managers
{
    /*
     * Bu sınıf merkezi sunucuya https istekleri gönderir.
     * Bu sınıf https ile aktif kullanıcıların bilgilerini
     * almayı amaçlar.
     */
    public class UserActivityManager : Singleton<UserActivityManager>
    {
        public async Task<List<User>> GetActiveUsersWithPaginationAsync(int pageNumber,int pageSize)
        {
            var client = new HttpClient();

            //URI
            string uri = $"https://localhost:7093/api/useractivity/getActiveUsers?" +
                $"pageSize={pageSize}&pageNumber={pageNumber}";

            // API KEY
            var apiKey = Environment.GetEnvironmentVariable("API_KEY");

            // JWT Token
            string token = AuthenticationManager.Instance.UserToken;

            // Authorization header içerisine JWT token eklenir
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers
                .AuthenticationHeaderValue("Bearer", token);

            //Api key header içersine eklenir.
            client.DefaultRequestHeaders.Add("x-api-key", apiKey);

            //GET isteği gönderilir
            HttpResponseMessage response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                // Response body'yi okuruz
                string responseBody = await response.Content.ReadAsStringAsync();

                // JSON verisini User listesine dönüştürürüz
                var users = JsonConvert.DeserializeObject<List<User>>(responseBody);

                return users;
            }
            else
            {
                MessageBox.Show("Getting Active Users With Pagination FAILED!");
                return new List<User>();
            }
        }
    }
}
