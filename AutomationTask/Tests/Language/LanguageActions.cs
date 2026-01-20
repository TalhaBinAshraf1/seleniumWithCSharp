using System;
using AutomationTask.Pages;
using AutomationTask.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationTask.Tests.Language
{
	public class LanguageActions
	{

        private readonly IWebDriver driver;
        private readonly LandingPageObjects landingPageObjects;
        private readonly UtilityActions utilityAction;


        public LanguageActions(IWebDriver driver)
        {
            this.driver = driver;
            landingPageObjects = new LandingPageObjects(driver);
            utilityAction = new UtilityActions(driver);
        }



        //Change the site language from English to Bangla and verify that the language is updated.
        public void VerifyLanguageChangeEnglishToBangla()
        {

            var searchBoxPlaceHolderText = landingPageObjects.SearchFieldPlaceHolderEN.GetAttribute("placeholder");
            Assert.That(searchBoxPlaceHolderText, Is.EqualTo("Search in Daraz"));
            landingPageObjects.LanguageButton.Click();
            landingPageObjects.BanglaLanguageButton.Click();
            var searchBoxPlaceHolderTextInBN = landingPageObjects.SearchFieldPlaceHolderBN.GetAttribute("placeholder");
            Assert.That(searchBoxPlaceHolderTextInBN, Is.EqualTo("দারাজ এ অনুসন্ধান"));
            Thread.Sleep(2000);
        }

        //Change the site language back from Bangla to English and verify that the language is updated.
        public void VerifyLanguageChangeBanglaToEnglish()
        {
            var searchBoxPlaceHolderText = landingPageObjects.SearchFieldPlaceHolderBN.GetAttribute("placeholder");
            Assert.That(searchBoxPlaceHolderText, Is.EqualTo("দারাজ এ অনুসন্ধান"));
            Thread.Sleep(2000);
            landingPageObjects.LanguageButton.Click();
            Thread.Sleep(2000);
            landingPageObjects.EnglishLanguageButton.Click();
            var searchBoxPlaceHolderTextInEN = landingPageObjects.SearchFieldPlaceHolderEN.GetAttribute("placeholder");
            Assert.That(searchBoxPlaceHolderTextInEN, Is.EqualTo("Search in Daraz"));
        }





    }
}

