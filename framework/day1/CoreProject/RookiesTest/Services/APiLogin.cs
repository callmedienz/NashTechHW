using CoreProject.DriverCore.APICore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookiesTest.Services
{
    public class APiLogin
    {
        public string userLoginPath = "/userslogin";

        public APIResponse LoginRequest(string username, string password)
        {
            APIResponse response = new APIRequest()
                    .SetURL("https://www.saucedemo.com/")
                   .AddHeader("Content-Type", "application/x-www-form-urlencoded")
                   .AddFormData("username", username)
                   .AddFormData("password", password)
                   .SendRequest();
            return response;

        }

        public UserLogin Login(string username, string password)
        {
            APIResponse response = LoginRequest(username, password);
            UserLogin userLogin = (UserLogin)JsonConvert.DeserializeObject
                <UserLogin>(response.responseBody);
            return userLogin;

        }
    }
}
