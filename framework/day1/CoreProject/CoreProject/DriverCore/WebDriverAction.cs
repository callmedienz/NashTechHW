using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using NUnit.Framework;

namespace CoreFramework.DriverCore
{
    public class WebDriverAction
    {
        public IWebDriver driver;
        public WebDriverAction(IWebDriver driver)
        {
            this.driver = driver;
        }
        public By ByXpath(string locator)
        {
            return ByXpath(locator);
        }
        public string getTitle()
        {
            return driver.Title;
        }
        public IWebElement FindElementByXpath(string locator)
        {
            IWebElement e = driver.FindElement(ByXpath(locator));
            hightlightElement(e);
            return e;
        }
        public IList<IWebElement> FindElementsByXpath(string locator)
        {
            return driver.FindElements(ByXpath(locator));
        }
        public IWebElement hightlightElement(IWebElement element)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].style.border='2px solid red'", element);
            return element;
        }
        public void Click(IWebElement e)
        {
            try
            {
                hightlightElement(e);
                e.Click();
                TestContext.Write("click into element" + e.ToString() + "passed");
            }
            catch (Exception ex)
            {
                TestContext.Write("click into element" + e.ToString() + "failed");
                throw ex;
            }
        }
        public void Click(string locator)
        {
            try
            {
                FindElementByXpath(locator).Click();
                TestContext.Write("click into element" + locator.ToString() + "passed");
            }
            catch (Exception ex)
            {
                TestContext.Write("click into element" + locator.ToString() + "failed");
                throw ex;
            }

        }
        public void Sendkey_(String locator, String key)
        {
            try
            {
                FindElementByXpath(locator).SendKeys(key);
                TestContext.Write("sendkey into element" + locator + "passed");

            }
            catch (Exception ex)
            {
                TestContext.Write("sendkey into element" + locator + "failed");
                throw ex;
            }
        }

    }
}