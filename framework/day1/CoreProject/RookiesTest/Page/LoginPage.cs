using CoreFramework.DriverCore;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookiesTest.Page
{
    public class LoginPage : WebDriverAction
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        private readonly String tfUserName = "//input[@name='uid']";
        public void inputUserName(string UserName)
        {
            Sendkey_(tfUserName, UserName);
        }
    }
}
