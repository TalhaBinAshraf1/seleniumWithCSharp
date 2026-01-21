using System;
using OpenQA.Selenium;

namespace AutomationTask.Pages
{
	public class LoginPageObjects
	{
        private readonly IWebDriver driver;

        public LoginPageObjects(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By HeaderTextWelcomneToDaraz => By.XPath("//h3[contains(text(),'Welcome to Daraz! Please login.')]");
        public By PhoneNumberField => By.XPath("//input[contains(@placeholder, 'Please enter your Phone')]");
        public By PasswordField => By.XPath("//input[contains(@placeholder,'Please enter your password')]");
        public By LoginButton => By.XPath("//button[contains(text(),'LOGIN')]");


    }
}

