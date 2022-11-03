using NUnit.Framework;
using CoreProject.NUnitTestSetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest.Test
{
    public class TestSetUp : NUnitTestSetup
    {
        [SetUp]
        public void SetUp() 
        {
            driver.url = "https://demo.guru99.com/v4/";
        }
        [TearDown]
        public void TearDown()
        {

        }
    }
}
