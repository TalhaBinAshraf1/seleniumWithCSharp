using System;
using AutomationTask.Pages;
using OpenQA.Selenium;

namespace AutomationTask.Tests.Language
{
	public class LanguageActions
	{
        private readonly IWebDriver driver;
        private readonly LandingPageObjects landingPageObjects;

        public LanguageActions(IWebDriver driver)
		{
			this.driver = driver;
			landingPageObjects = new LandingPageObjects(driver);
        }

		public void searchOnSearchber() {
			landingPageObjects.SearchInputField.SendKeys("bike");
			landingPageObjects.SearchInputField.SendKeys(Keys.Enter);
		}
	}
}

