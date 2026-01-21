using System;
using Allure.NUnit.Attributes;
using AutomationTask.Config;

namespace AutomationTask.Tests.UserRegistration
{
    [TestFixture]
    [Category("Smoke")]
    [AllureSuite("Language")]
    [AllureEpic("ChangeLanguage")]
    public class UserRegistrationTests : BaseTest
	{
        [Test]
        [Description("Varify that user can Register")]
        [AllureFeature("Varify that user can Register")]


        public void UserRegistration(){
            UserRegistrationActions userRegistrationActions = new UserRegistrationActions(driver);

            //Register a new user account.
            userRegistrationActions.NavigateTORegistrationPage();
            userRegistrationActions.VerifyPageHader();
            userRegistrationActions.EnterMobileNumberInMobileField();
            userRegistrationActions.InputCode();
            userRegistrationActions.InputPassword();
            userRegistrationActions.InputFullName();
            userRegistrationActions.SelectDropdownValues();
            userRegistrationActions.ClickOnPromotionalSMS();
            //userRegistrationActions.ClickOnSignUp();



        }
    }
}

