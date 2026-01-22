using System;
//using Allure.NUnit.Attributes;
using NUnit.Framework;
using AutomationTask.Config;

namespace AutomationTask.Tests.Language
{
    [TestFixture]
    [Category("Smoke")]
    [Category("LanguageChange")]
    //[AllureSuite("Language")]
    //[AllureEpic("Validate user able to ChangeLanguage")]

    public class LaguageTests: BaseTest
	{
		[Test]
		[Description("Validate that user can Switch the language")]
        //[AllureFeature("Validate that user can Switch the language")]

        public void ValidateChangeLanguage() {
			LanguageActions languageActions = new LanguageActions(driver);

			languageActions.VerifyLanguageChangeEnglishToBangla();
			languageActions.VerifyLanguageChangeBanglaToEnglish();
            extentTest.Info("User able to change Lanuage Sucessfully");
        }

    }
}

