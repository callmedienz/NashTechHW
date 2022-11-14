using CoreFramework.UnitTestSetup;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelniumAdvanced_Day3.SetUp
{
    public class Day3ProjectSetup : NUnitTestSetup
    {
        [SetUp]
        public void SetUp()
        {
            _driver.Url = "https://apichallenges.herokuapp.com";
        }
        [TearDown]
        public void TearDown()
        {
        }
    }
}
