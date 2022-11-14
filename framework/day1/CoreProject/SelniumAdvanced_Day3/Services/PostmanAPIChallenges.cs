using CoreProject.DriverCore.APICore;
using MongoDB.Bson.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelniumAdvanced_day3.Services
{
    public class PostmanAPIChallenges
    {
        public string req04_path = "/todo";

        public APIResponse req04()
        {
            APIResponse response = new APIRequest()
                   .SetUrl("https://apichallenges.herokuapp.com" + req04_path)
                   .SendRequest();
            return response;
        }

        public string req05_path = "/todos/900";
        public APIResponse req05()
        {
            APIResponse response = new APIRequest().
                   SetUrl("https://apichallenges.herokuapp.com" + req05_path)
                   .SendRequest();
            return response;
        }

        public string req06_path = "/todos/500";
        public APIResponse req06()
        {
            APIResponse response = new APIRequest().
                   SetUrl("https://apichallenges.herokuapp.com" + req06_path)
                   .SendRequest();
            return response;
        }

        public string req07_path = "/todos";
        public APIResponse req07()
        {
            APIResponse response = new APIRequest().
                   SetUrl("https://apichallenges.herokuapp.com" + req07_path)
                   .SendRequest();
            return response;
        }

        public string req08_path = "/todos";
        public APIResponse req08()
        {
            APIResponse response = new APIRequest().
                   SetUrl("https://apichallenges.herokuapp.com" + req08_path)
                   .SendRequest();
            return response;
        }

        public string req09_path = "/todos";
        public APIResponse req09()
        {
            APIResponse response = new APIRequest().
                   SetUrl("https://apichallenges.herokuapp.com" + req09_path)
                   .SendRequest();
            return response;
        }

        public string req10_path = "/todos";
        public APIResponse req10()
        {
            APIResponse response = new APIRequest().
                   SetUrl("https://apichallenges.herokuapp.com" + req10_path)
                   .SendRequest();
            return response;
        }

        public string req11_path = "/todos";
        public APIResponse req11()
        {
            APIResponse response = new APIRequest().
                   SetUrl("https://apichallenges.herokuapp.com" + req11_path)
                   .SendRequest();
            return response;
        }

        public string req12_path = "/todos";
        public APIResponse req12()
        {
            APIResponse response = new APIRequest().
                   SetUrl("https://apichallenges.herokuapp.com" + req12_path)
                   .SendRequest();
            return response;
        }

        public string req13_path = "/todos";
        public APIResponse req13()
        {
            APIResponse response = new APIRequest().
                   SetUrl("https://apichallenges.herokuapp.com" + req13_path)
                   .SendRequest();
            return response;
        }
    }
}
