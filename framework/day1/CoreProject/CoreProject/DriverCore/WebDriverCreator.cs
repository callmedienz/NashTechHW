using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreFramework.DriverCore
{
    internal class WebDriverCreator
    {
        public static IWebDriver CreateLocalDriver(string Browser, int ScreenWidth, int ScreenHight)
        {
            IWebDriver? Driver = null;
            if (Browser.SequenceEqual("firefox"))
            {
                Driver = new FirefoxDriver();
            }
            else if (Browser.SequenceEqual("chrome"))
            {
                Driver = new ChromeDriver();
            }
            else if (Browser.SequenceEqual("safari"))
            {
                Driver = new SafariDriver();
            }
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Size = new Size(ScreenWidth, ScreenHight);
            return Driver;
        }
        public static IWebDriver CreateBrowserstackDriver(string Browser, int ScreenWidth, int ScreenHight)
        {
            IWebDriver? Driver = null;
            if (Browser.SequenceEqual("firefox"))
            {
                Driver = new FirefoxDriver();
            }
            else if (Browser.SequenceEqual("chrome"))
            {
                Driver = new ChromeDriver();
            }
            else if (Browser.SequenceEqual("safari"))
            {
                Driver = new SafariDriver();
            }
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Size = new Size(ScreenWidth, ScreenHight);
            return Driver;
        }
    }
}