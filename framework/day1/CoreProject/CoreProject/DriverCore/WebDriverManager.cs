using System;
using System.Threading;
using OpenQA.Selenium;



namespace CoreProject.DriverCore
{
    internal class WebDriverManager_
    {
        private static AsyncLocal<IWebDriver> driver = new AsyncLocal<IWebDriver>();
        public static void InitDriver(String Browser, int Width, int Height)
        {
            IWebDriver newDriver = null;
            newDriver = WebDriverCreator.CreateLocalDriver(Browser, Width, Width);

            if (newDriver == null)
                throw new Exception($"{Browser} does not supported");
            driver.Value = newDriver;
        }
        public static IWebDriver GerCurrentDriver()
        {
            return driver.Value;
        }
        public static void CloseDriver()
        {
            if (driver.Value != null)
            {
                driver.Value.Quit();
                driver.Value.Dispose();
            }
        }
    }
}