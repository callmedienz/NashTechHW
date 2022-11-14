using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;


namespace CoreProject.DriverCore.APICore
{
    public class APIResponse
    {
        public HttpWebResponse response;
        public string responseBody { get; set; }
        public string responseStatusCode { get; set; }
        public APIResponse(HttpWebResponse response)
        {
            this.response = response;
            
        }
        private string GetBodyResponse()
        {
            responseBody = "";
            using (var responseStream = response.GetResponseStream())
            {

            }
            return responseBody;
        }
        private string GetResponseStatusCode()
        {
            try
            {
                HttpStatusCode statusCode = ((HttpWebResponse)response).StatusCode;
                responseStatusCode = statusCode.ToString();
            }
            catch (WebException we)
            {
                responseStatusCode = ((HttpWebResponse)we.Response).StatusCode.ToString();

            }
            return responseStatusCode;
        }
        
        

    }
}
