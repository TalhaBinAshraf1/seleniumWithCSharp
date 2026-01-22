//using Allure.NUnit.Attributes;
using AutomationTask.Pages;
using AutomationTask.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationTask.Tests.Language
{
    public class LanguageActions
    {
        private readonly IWebDriver driver;
        private readonly LandingPageObjects landingPage;
        private readonly UtilityActions utility;

        public LanguageActions(IWebDriver driver)
        {
            this.driver = driver;
            landingPage = new LandingPageObjects(driver);
            utility = new UtilityActions(driver);
        }

        //[AllureStep("Change site language from English to Bangla and verify")]
        public void VerifyLanguageChangeEnglishToBangla()
        {
            string placeholderEN = utility.GetAttribute(landingPage.SearchInputField,"placeholder");
            Assert.That(placeholderEN, Is.EqualTo("Search in Daraz"));

            utility.Click(landingPage.LanguageButton);
            utility.Click(landingPage.BanglaLanguageButton);

            utility.WaitForAttributeValue(landingPage.SearchInputField,"placeholder","দারাজ এ অনুসন্ধান");
            string placeholderBN = utility.GetAttribute(landingPage.SearchInputField,"placeholder");
            Assert.That(placeholderBN, Is.EqualTo("দারাজ এ অনুসন্ধান"));
        }

        //[AllureStep("Change site language from Bangla to English and verify")]
        public void VerifyLanguageChangeBanglaToEnglish()
        {
            string placeholderBN = utility.GetAttribute(landingPage.SearchInputField,"placeholder");
            Assert.That(placeholderBN, Is.EqualTo("দারাজ এ অনুসন্ধান"));

            utility.Click(landingPage.LanguageButton);
            utility.Click(landingPage.EnglishLanguageButton);

            utility.WaitForAttributeValue(landingPage.SearchInputField,"placeholder","Search in Daraz");

            string placeholderEN = utility.GetAttribute( landingPage.SearchInputField,"placeholder");

            Assert.That(placeholderEN, Is.EqualTo("Search in Daraz"));
        }
    }
}

