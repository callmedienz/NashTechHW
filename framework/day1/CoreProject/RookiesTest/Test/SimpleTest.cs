using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using RookiesTest.Page;
using RookiesTest.SetUp;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookiesTest.Test
{
    public class SimpleTest : RookiesNUnitTestSetUp
    {
        [Test]
        public void UserCanSearchVideo()
        {
            LoginPage loginPage = new LoginPage(_driver);
            loginPage.inputUserName("test");
        }
    }
}
