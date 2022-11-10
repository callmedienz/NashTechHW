using NUnit.Framework;
using AventStack.ExtentReports;
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
        public void simpleTest()
        {
            SearchPage searchPage = new SearchPage(_driver);
            ResultPage resultPage = new ResultPage(_driver);

            searchPage.inputSearchKey("Selenium");
            searchPage.getResultPage();

            resultPage.verifySearchTitle("Selenium");
            resultPage.clickOnFirstResult();
            resultPage.verifyPageSearchBoxText("Search");

        }
    }
}
