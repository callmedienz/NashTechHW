using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreProject.DriverCore;
using OpenQA.Selenium;

namespace SeleniumAdvanced_day2.SeleniumScenario1Converted
{
    public class Page : WebDriverAction
    {
        public Page(IWebDriver? driver) : base(driver)
        {
        }
        private readonly string contactUsBtnLocator = "//*[text()='Contact us']";
        private readonly string csTitleLocator = "//*[contains(@class, 'page-heading')]";
        public void VerifyText(string expectedText)
        {
            Assert_(GetTextFromElement(csTitleLocator), expectedText);
        }
        public void ClickBtn()
        {
            Click(contactUsBtnLocator);
        }

        public void VerifyPageTitle(string expectedpageTitle)
        {
            Assert_(GetTitle(), expectedpageTitle);
        }

    }
}
