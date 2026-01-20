using System;
using AutomationTask.Config;

namespace AutomationTask.Tests.Language
{
    [TestFixture]
    [Category("Smoke")]
    public class LaguageTests : BaseTest
	{
		[Test]
		[Description("Varify that user can Switch the language")]
		public void VarifyChangeLanguage() {

			LanguageActions languageActions = new LanguageActions(driver);

			languageActions.VerifyLanguageChangeEnglishToBangla();
			languageActions.VerifyLanguageChangeBanglaToEnglish();
		}

	}
}

