using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoreProject.DriverCore
{
    public class WebDriverManagement
    {
        private static AsyncLocal<IWebDriver> driver = new AsyncLocal<IWebDriver>();

        public static void InitDriver(string Browser, int Width, int Height)
        { 
            IWebDriver newDriver = null;
            if (newDriver == null)
            {
                throw new Exception($"{Browser} is not supported");
            }
        }
        public static IWebDriver GetCurrentDriver()
        {
            return driver.Value;
        }

        public static CloseDriver()
        {
            if (driver.Value == null)
            {
                driver.Value.Quit();
                driver.Value.Dispose();
            }
        }
    }
}
