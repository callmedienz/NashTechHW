using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Threading;
using System;

namespace autotest
{
    [TestFixture]
    public class Class1
    {
        protected WebDriverWait? _wait;
        protected IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        [Test]
        public void ShopTest()
        { 
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            Console.WriteLine("Website open successfully");
            _driver.FindElement(By.Id("contact-link")).Click();

            string Actual1 = _driver.Title;
            string expected1 = "Contact us - My Store";            
            Assert.AreEqual(expected1, Actual1);
            _driver.Navigate().Back();
            string Actual2 = _driver.Title;
            string expected2 = "My Store";
            Assert.AreEqual(expected2 , Actual2);
            _driver.Navigate().Forward();
            _driver.Close();


            /*_driver.Navigate().Refresh();
            Console.WriteLine($"Driver title is: [{_driver.Title}]");
            Console.WriteLine($"Page source is: [{_driver.PageSource}]");
            (_driver as IJavaScriptExecutor).ExecuteScript("window.open('about:blank', '_blank');");
            (_driver as IJavaScriptExecutor).ExecuteScript("window.open('about:blank', '_blank');");
            _driver.Navigate().Refresh();
            _driver.Navigate().GoToUrl("https://youtube.com");
            _driver.SwitchTo().Window(_driver.WindowHandles[1]);
            _driver.Close();*/


        }

        [Test]
        public void ELementCommandTest()
        {
            _driver.Navigate().GoToUrl("https://youtube.com");
            IList<IWebElement> tags = _driver.FindElements(By.XPath("//yt-chip-cloud-chip-rerender"));
            Console.WriteLine($"These are [{tags.Count}] tags:");
            for (int i = 0; i < tags.Count; i++)
            {
                Console.WriteLine($"- TAgs ({i + 1}): [{tags[i]}] tags: ");
            }
            IWebElement searchbox = _driver.FindElement(By.CssSelector("input[id='search]'"));
        }
    }
}