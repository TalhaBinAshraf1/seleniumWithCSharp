using System;
using Allure.NUnit.Attributes;
using AutomationTask.Config;

namespace AutomationTask.Tests.Language
{
    [TestFixture]
    [Category("Smoke")]
    [AllureSuite("Language")]
    [AllureEpic("ChangeLanguage")]
    public class LaguageTests : BaseTest
	{
		[Test]
		[Description("Validate that user can Switch the language")]
        [AllureFeature("Validate that user can Switch the language")]

        public void VarifyChangeLanguage() {

			LanguageActions languageActions = new LanguageActions(driver);

			languageActions.VerifyLanguageChangeEnglishToBangla();
			languageActions.VerifyLanguageChangeBanglaToEnglish();
        }

    }
}

