using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Oenskeportalen.Models;

namespace Oenskeportalen.RestApiClass
{
    class RestClient<T>
    {
        private const string AuthenticationUrl = "https://oenskeportalen.zap345502-1.plesk08.zap-webspace.com/API/Users/read_one.php";
        public async Task<bool> CheckLogin(string email, string password)
        {
            //var returnResponse = new MainResponse();
            var httpClient = new HttpClient(new HttpClientHandler());
            var response = await httpClient.GetAsync(AuthenticationUrl+ "?email=" + email + "&password=" + password);

            /*if (response.IsSuccessStatusCode)
            {
                string contentStr = await response.Content.ReadAsStringAsync();
                returnResponse = JsonConvert.DeserializeObject<MainResponse>(contentStr);
            }*/

            return response.IsSuccessStatusCode;
        }
    }
}
