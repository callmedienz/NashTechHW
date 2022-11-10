using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RookiesTest.Page
{
    public class Video : HeaderPage
    {
        public Video(IWebDriver? driver) : base(driver)
        {
        }

        public IWebElement? GetVideoByTitle(string videoByTitle)
        {
            By video = By.XPath($"//yt-formatted-string[contains(text(),'{videoByTitle}')]");
            return _driver?.FindElement(video);
        }

        public VideoDetail OpenVideo(string videoTitle)
        {
            GetVideoByTitle(videoTitle)?.Click();
            return new VideoDetail(_driver);
        }
    }
}
