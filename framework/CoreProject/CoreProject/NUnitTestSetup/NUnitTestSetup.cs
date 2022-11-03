
using CoreProject.DriverCore;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.NUnitTestSetup
{
    public class NUnitTestSetup
    {
        protected IWebDriver? _driver;
        public WebDriverAction? driverBaseAction;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
        }

        [TearDown]
        public void TearDown()
        {
            _driver?.Quit();
            TestStatus testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            if (testStatus.Equals(TestStatus.Passed))
            {
                TestContext.WriteLine("Passed");
            }
            else if (testStatus.Equals(TestStatus.Failed))
            {
                TestContext.WriteLine("Failed");
                driverBaseAction.Screenshoot();
            }
        }

        [Test]
        public void UserCanSearchVideos()
        {

        }
        
        public int? GetRandomNumber()
        {
            return null;
        }
        public void ElementsCommandTest(string a)
        {
            Console.WriteLine(a);
        }

    }
}
