using AventStack.ExtentReports.MarkupUtils;
using CoreProject.DriverCore.APICore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.Reporter.ExtentMarkup
{
    public class MarkupHelperPlus
    {
        public static IMarkup CreateAPIRequestLog(APIRequest request, APIResponse response)
        {
            return new APIRequestLog(request, response);
        }
    }
}
