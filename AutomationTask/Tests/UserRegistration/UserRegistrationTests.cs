using System;
using AutomationTask.Config;

namespace AutomationTask.Tests.UserRegistration
{
    [TestFixture]
    [Category("Smoke")]
    public class UserRegistrationTests : BaseTest
	{
        [Test]
        [Description("Varify that user can Switch the language")]
        public void UserRegistration(){
            UserRegistrationActions userRegistrationActions = new UserRegistrationActions(driver);

            //Register a new user account.
            userRegistrationActions.ClickOnSignUp();
            
		}
	}
}

