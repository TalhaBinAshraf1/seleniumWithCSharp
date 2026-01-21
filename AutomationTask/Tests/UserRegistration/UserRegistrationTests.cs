using System;
using Allure.NUnit.Attributes;
using AutomationTask.Config;

namespace AutomationTask.Tests.UserRegistration
{
    [TestFixture]
    [Category("Smoke")]
    [Category("UserRegistration")]
    [AllureSuite("User")]
    [AllureEpic("UserRegistration")]

    public class UserRegistrationTests: BaseTest
	{
        [Test]
        [Description("Validate that user can Register with PhoneNumber")]
        [AllureFeature("Validate that user can Register with PhoneNumber")]

        public void ValidateUserRegistration(){
            UserRegistrationActions userRegistrationActions = new UserRegistrationActions(driver);

            userRegistrationActions.ValidateUserAbleToRegisterSucessfully();
        }
    }
}

