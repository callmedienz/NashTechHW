using CoreProject.DriverCore.APICore;
using RookiesTest.SetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace RookiesTest.Test
{
    public class APITest : RookiesNUnitTestSetUp
    {
        APIResponse response = new MockAPIService().LoginRequest("daongochuy", "aloalo1234");
        Assert.AreEqual(Response.GetResponseStatusCode, "200");
    }
}
