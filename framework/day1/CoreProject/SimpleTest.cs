using NUnit.Framework;
using RookieTest.Page;
using RookieTest.TestSetup;

namespace RookieTest
{
    public class Tests : ProjectNUnitTestSetup
    {
        [Test]
        public void LoginTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.InputUserName("test");

        }
    }
}