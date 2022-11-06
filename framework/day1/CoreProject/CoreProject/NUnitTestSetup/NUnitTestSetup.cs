using CoreFramework.DriverCore;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium;

namespace CoreFramework.UnitTestSetup
{
    [TestFixture]
    public class NUnitTestSetup
    {
        public IWebDriver? _driver;
        public WebDriverAction driverBaseAction;
        public WebDriverWait? _wait;
        protected ExtentsReport? _extentsReport;
        protected extnentsTest? _extnentsTest;

        [SetUp]
        public void SetUp()
        {
            WebDriverManager_.InitDriver("chrome", 1920, 1080);
            _driver = WebDriverManager_.GerCurrentDriver();
            driverBaseAction = new WebDriverAction(_driver);
            _extnentsTest = _extentsReport.CreateTest($"{TestContext.CurrentContext.Test.Name}");
        }
        [TearDown]
        public void TearDown()
        {
            _driver?.Quit();
            TestStatus testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            if (testStatus.Equals(TestStatus.Passed))
            {
                TestContext.WriteLine("passed");
            }
            else if (testStatus.Equals(TestStatus.Failed))
            {
                TestContext.WriteLine("failed");
            }
            _extentsReport.Flush();
        }
    }
}