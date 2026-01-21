using System;
using AutomationTask.Pages;
using AutomationTask.Utils;
using OpenQA.Selenium;

namespace AutomationTask.Tests.UserLogin
{
	public class UserLoginActions
	{
        private readonly IWebDriver driver;
        private readonly UtilityActions utility;
        private readonly LoginPageObjects loginPageObjects;

        public UserLoginActions(IWebDriver driver)
		{
            this.driver = driver;
            utility = new UtilityActions(driver);
            loginPageObjects = new LoginPageObjects(driver);
        }

        //navigate to login
        public void NavigateToLoginPage() {
            driver.Navigate().GoToUrl(Utility.TestData.LoginPageUrl);
        }

        //Validate Header
        public void VerifyPageHader()
        {
            string HeaderText = utility.GetText(loginPageObjects.HeaderTextWelcomneToDaraz);
            Assert.That(HeaderText, Is.EqualTo("Welcome to Daraz! Please login."));
        }

        //input UserMobileNumber
        public void InputUserPhoneNumber()
        {
            utility.Click(loginPageObjects.PhoneNumberField);
            utility.Type(loginPageObjects.PhoneNumberField, Utility.TestData.PhoneNumber);
        }

        //Input Password
        public void InputUserPassword()
        {
            utility.Click(loginPageObjects.PasswordField);
            utility.Type(loginPageObjects.PasswordField, Utility.TestData.Password);
        }

        public void ClickOnLoginbutton() {
            utility.Click(loginPageObjects.LoginButton);
        }

        public void VerifyUserAbleToLogiInSucessfully() {
            string ProfileText = utility.GetText(loginPageObjects.ProfileName);
            Assert.That(ProfileText, Is.EqualTo("TALHATEST'S ACCOUNT"));
        }

        //Combine Method
        public void ValidateUserAbleToLogin() {

            NavigateToLoginPage();
            VerifyPageHader();
            InputUserPhoneNumber();
            InputUserPassword();
            ClickOnLoginbutton();
            VerifyUserAbleToLogiInSucessfully();
        }

    }
}

