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
        [Description("Validate that user can Register")]
        [AllureFeature("Validate that user can Register")]


        public void ValidateUserRegistration(){

            UserRegistrationActions userRegistrationActions = new UserRegistrationActions(driver);

            userRegistrationActions.ValidateUserAbleToRegisterSucessfully();
        }
    }
}

