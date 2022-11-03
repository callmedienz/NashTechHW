using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.DriverCore
{
    public class WebDriverAction
    {
        public IWebDriver driver;
        public WebDriverWait explicitWait;

        public WebDriverAction(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By byXPath(string locator)
        {
            return By.XPath(locator);
        }

        public string GetTitle()
        {
            return driver.Title;
        }
        public IWebElement FindElementByXPath(string locator)
        {
            IWebElement e = driver.FindElement(byXPath(locator));
            HighlightElement(e);
            return e;
        }
        public IList<IWebElement> FindElementsByXPath(string locator)
        {
            return driver.FindElements(byXPath(locator));
        }
        public IWebDriver HighlightElement (IWebDriver element)
        {
            IJavaScriptExecutor jse =(IJavaScriptExecutor)driver;

            jse.ExecuteScript("arguments [0].style.border='2px solid red'", element);
            return element;
        }
        public void Click(IWebElement e)
        {
            try
            {
                HighlightElement(e);
                e.Click();
                TestContext.Write("click into element " + e.ToString() + "passed");
            }
            catch (Exception err)
            {
                TestContext.Write("click into element " + e.ToString() + "failed");
                throw err;
            }
        }
        public void Click(string locator)
        {
            try
            {
                FindElementByXPath(locator).Click();
                TestContext.Write("click into element " + locator + "passed");
            }
            catch (Exception err)
            {
                TestContext.Write("click into element " + locator + "failed");
                throw err;
            }
        }
        public void SendKeys_(IWebElement e,string key)
        {
            try
            {
                e.SendKeys(key);
                TestContext.Write("send keys into element " + e.ToString() + "passed");
            }
            catch (Exception err)
            {
                TestContext.Write("send key into element " + e.ToString() + "failed");
                throw err;
            }
        }
        public void SendKeys_(string locator, string key)
        {
            try
            {
                FindElementByXPath(locator).SendKeys(key);
                TestContext.Write("send keys into element " + locator + "passed");
            }
            catch (Exception err)
            {
                TestContext.Write("send key into element " + locator + "failed");
                throw err;
            }
        }
        // action select option
        public void SelectOption(String locator, String key)
        {
            try
            {
                IWebElement mySelectOption = FindElementByXPath(locator);
                SelectElement dropdown = new SelectElement(mySelectOption);
                dropdown.SelectByText(key);
                TestContext.WriteLine("Select element " + locator + " successfuly with " + key);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine("Select element " + locator + " failed with " + key);
                throw ex;
            }
        }
        // action get screenshot
        public void Screenshoot()
        {
            try
            {

                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile("Test.jpg", ScreenshotImageFormat.Jpeg);
                TestContext.WriteLine("Take screen shot successfully");
            }
            catch (Exception ex)
            {
                TestContext.WriteLine("Take screen shot failed");
                throw ex;
            }
        }
        public IWebElement highlightElement(IWebElement element)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].style.border='2px solid red'", element);
            return element;
        }
    }
}

