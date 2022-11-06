using CoreFramework.UnitTestSetup;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookiesTest.SetUp
{
    public class RookiesNUnitTestSetUp : NUnitTestSetup
    {

        [SetUp]
        public void SetUp()
        {
            _driver.Url = "https://demo.guru99.com/v4/";
        }
        [TearDown]
        public void TearDown()
        {

        }
    }
}
