using System;
using System.Xml.Linq;
using AutomationTask.Pages;
using AutomationTask.Utils;
using OpenQA.Selenium;

namespace AutomationTask.Tests.UserRegistration
{
	public class UserRegistrationActions
	{
        private readonly IWebDriver driver;
        private readonly UtilityActions utility;
        private readonly RegisterPageObjects registerPageObjects;

        public UserRegistrationActions(IWebDriver driver)
		{
            this.driver = driver;
            utility = new UtilityActions(driver);
            registerPageObjects = new RegisterPageObjects(driver);

        }

        public void NavigateTORegistrationPage()
        {
            driver.Navigate().GoToUrl(Utility.TestData.RegistetionPageUrl);
        }

        public void VerifyPageHader() {
            string HeaderText = utility.GetText(registerPageObjects.HeaderTextCreateAccount);
            Assert.That(HeaderText, Is.EqualTo("Create your Daraz Account"));
        }

        ////input the mobile field
        public void EnterMobileNumberInMobileField()
        {
            utility.Click(registerPageObjects.PhoneNumberField);
            utility.Type(registerPageObjects.PhoneNumberField, "8801553450570");
        }

        //Input Verification Code
        public void InputCode() {
            //utility.Click(registerPageObjects.SMSVerificationField);
            utility.Type(registerPageObjects.SMSVerificationField, "xxxxxx");
        }

        //Inputpassword
        public void InputPassword() {
            utility.Click(registerPageObjects.PasswordField);
            utility.Type(registerPageObjects.PasswordField, "Secret@44451");

        }

        //Input Full Name
        public void InputFullName(){
            utility.Click(registerPageObjects.FullNameField);
            utility.Type(registerPageObjects.FullNameField, "DarazUser");

        }

        //Select Dropdown
        public void SelectDropdownValues() {
            utility.Click(registerPageObjects.Month);
            utility.Click(registerPageObjects.MonthValue);
            utility.Click(registerPageObjects.Day);
            utility.Click(registerPageObjects.DayValue);
            utility.Click(registerPageObjects.Year);
            utility.Click(registerPageObjects.YearValue);
            utility.Click(registerPageObjects.Gender);
            utility.Click(registerPageObjects.GenderValue);
        }

        // Click on Promotional SMS
        public void ClickOnPromotionalSMS()
        {
            utility.Click(registerPageObjects.PromotionSMSCheckbox);

        }

        //Click on Sign Up
        public void ClickOnSignUp() {
            utility.Click(registerPageObjects.SignUpButton);
        }

        //CombindMethod
        public void ValidateUserAbleToRegisterSucessfully() {

           NavigateTORegistrationPage();
           VerifyPageHader();
           EnterMobileNumberInMobileField();
           InputCode();
           InputPassword();
           InputFullName();
           SelectDropdownValues();
           ClickOnPromotionalSMS();
           //ClickOnSignUp();
        } 


    }
}

