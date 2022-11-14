using CoreProject.DriverCore.APICore;
using RookiesTest.SetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using RookiesTest.Services;

namespace RookiesTest.Test
{
    [TestFixture]
    public class APITest : RookiesNUnitTestSetUp
    {
        [Test]
        public void RequestAPITest()
        {
        APIResponse response = new APiLogin().LoginRequest("daongochuy", "aloalo1234");
        Assert.That(response.responseStatusCode, Is.EqualTo("OK"));
        }
        
    }
}
