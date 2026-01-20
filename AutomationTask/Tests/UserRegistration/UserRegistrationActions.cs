using System;
using AutomationTask.Pages;
using OpenQA.Selenium;

namespace AutomationTask.Tests.UserRegistration
{
	public class UserRegistrationActions
	{
        private readonly IWebDriver driver;
        private readonly LandingPageObjects landingPageObjects;

        public UserRegistrationActions(IWebDriver driver)
		{
            this.driver = driver;
            landingPageObjects = new LandingPageObjects(driver);
        }

        //Register a new user account.

        public void ClickOnSignUp()
        {
            landingPageObjects.SignUpButton.Click();
            Thread.Sleep(2000);
        }

        public void MobileInputFieldAppered() {

        }

        public void validateUserRegistration() {

        }
    }
}

