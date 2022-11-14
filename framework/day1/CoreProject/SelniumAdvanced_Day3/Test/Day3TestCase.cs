using CoreProject.DriverCore.APICore;
using NUnit.Framework;
using SelniumAdvanced_day3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelniumAdvanced_Day3.Test
{
    public class Day3TestCase
    {
        public void APIRequestTest04()
        {
            APIResponse response = new PostmanAPIChallenges().req04();
            Assert.That(response.responseStatusCode, Is.EqualTo("NotFound"));
        }
        [Test]
        public void APIRequestTest05()
        {
            APIResponse response = new PostmanAPIChallenges().req05();
            Assert.That(response.responseStatusCode, Is.EqualTo("OK"));
        }
        [Test]
        public void APIRequestTest06()
        {
            APIResponse response = new PostmanAPIChallenges().req06();
            Assert.That(response.responseStatusCode, Is.EqualTo("NotFound"));
        }
        [Test]
        public void APIRequestTest07()
        {
            APIResponse response = new PostmanAPIChallenges().req07();
            Assert.That(response.responseStatusCode, Is.EqualTo("NotFound"));
        }
        [Test]
        public void APIRequestTest08()
        {
            APIResponse response = new PostmanAPIChallenges().req08();
            Assert.That(response.responseStatusCode, Is.EqualTo("OK"));
        }
        [Test]
        public void APIRequestTest09()
        {
            APIResponse response = new PostmanAPIChallenges().req09();
            Assert.That(response.responseStatusCode, Is.EqualTo("OK"));
        }
        [Test]
        public void APIRequestTest10()
        {
            APIResponse response = new PostmanAPIChallenges().req10();
            Assert.That(response.responseStatusCode, Is.EqualTo("BadRequest"));
        }
        [Test]
        public void APIRequestTest11()
        {
            APIResponse response = new PostmanAPIChallenges().req11();
            Assert.That(response.responseStatusCode, Is.EqualTo("OK"));
        }
        [Test]
        public void APIRequestTest12()
        {
            APIResponse response = new PostmanAPIChallenges().req12();
            Assert.That(response.responseStatusCode, Is.EqualTo("OK"));
        }
        [Test]
        public void APIRequestTest13()
        {
            APIResponse response = new PostmanAPIChallenges().req13();
            Assert.That(response.responseStatusCode, Is.EqualTo("OK"));
        }

    }
}
