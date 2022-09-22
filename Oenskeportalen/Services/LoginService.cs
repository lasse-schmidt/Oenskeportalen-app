using Oenskeportalen.RestApiClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Oenskeportalen.Models;

namespace Oenskeportalen.Services
{
    class LoginService
    {
        RestClient<LoginModel> restClient = new RestClient<LoginModel>();
        public async Task<bool> CheckLoginIfExists(string email, string password)
        {
            var check = await restClient.CheckLogin(email, password);
            return check;
        }
    }
}
