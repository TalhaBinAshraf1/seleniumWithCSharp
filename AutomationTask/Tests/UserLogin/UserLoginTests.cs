using System;
using Allure.NUnit.Attributes;
using AutomationTask.Config;

namespace AutomationTask.Tests.UserLogin
{
    [TestFixture]
    [Category("Smoke")]
    [Category("Login")]
    [AllureSuite("Login")]
    [AllureEpic("Validate User Able to Login")]
    public class UserLoginTests: BaseTest
    {
        [Test]
        [Description("Validate that user can Login")]
        [AllureFeature("Validate that user can Login")]

        public void ValidateUserAbleToLoginTests()
		{
            UserLoginActions userLoginActions = new UserLoginActions(driver);

            userLoginActions.ValidateUserAbleToLogin();
			
        }
    }
}

