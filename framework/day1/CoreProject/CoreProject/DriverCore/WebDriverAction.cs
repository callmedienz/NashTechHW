﻿using System;
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
using CoreProject.Reporter;

namespace CoreProject.DriverCore
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
                HtmlReport.Pass("click into element" + locator.ToString() + "passed");
            }
            catch (Exception ex)
            {
                HtmlReport.Fail("click into element" + locator.ToString() + "failed");
                throw ex;
            }

        }
        public void SendKeys_(IWebElement e, string key)
        {
            try
            {
                e.SendKeys(key);
                HtmlReport.Pass("SendKey into element " + e.ToString() + "passed");

            }
            catch (Exception ex)
            {
                HtmlReport.Fail("SendKey into element " + e.ToString() + "failed");
                throw ex;
            }
        }
        public void Sendkey_(String locator, String key)
        {
            try
            {
                FindElementByXpath(locator).SendKeys(key);
                HtmlReport.Pass("sendkey into element" + locator + "passed");

            }
            catch (Exception ex)
            {
                HtmlReport.Fail("sendkey into element" + locator + "failed");
                throw ex;
            }
        }
        public string ScreenShot()
        {
            try
            {
                string path = HtmlReportDirectory.SCREENSHOT_PATH + ("/screenshot_" + DateTime.Now.ToString("yyyyMMddHHmmss")) + ".png";
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(path, ScreenshotImageFormat.Png);
                return path;
            }catch (Exception ex)
            {
                HtmlReport.Fail("Take screenshot failed");
                throw ex;
            }
        }
        public void ScreenShootWhen404()
        {
            if(driver.Title.Contains("404"))
            {
                ScreenShot();
                HtmlReport.Warning("Error 404");
            }ScreenShot();
        }
        public void Back()
        {
            driver.Navigate().Back();
        }
        public void Forward()
        {
            driver.Navigate().Forward();
        }

        public String GetText(string locator)
        {
            string e = FindElementByXpath(locator).Text;
            return e;
        }

    }
}