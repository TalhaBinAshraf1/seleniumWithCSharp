using OpenQA.Selenium;

namespace AutomationTask.Pages
{
    public class LandingPageObjects
    {
        private readonly IWebDriver driver;

        public LandingPageObjects(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By LanguageButton => By.Id("topActionSwitchLang");
        public By LoginButton => By.Id("anonLogin");
        public By SignUpButton => By.Id("anonSignup");

        public By EnglishLanguageButton => By.CssSelector("div.lzd-switch-item[data-lang='en']");

        public By BanglaLanguageButton => By.CssSelector("div.lzd-switch-item[data-lang='bn']");

        public By SearchInputField => By.Name("q");
        public By MobileNumberInputField => By.XPath("(//input[@placeholder='Please enter your phone number'])[2]");
    }
}


