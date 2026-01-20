using System;
using OpenQA.Selenium;

namespace AutomationTask.Pages
{
	public class LandingPageObjects{
        private readonly IWebDriver driver;

    // Constructor assisn as field
    public LandingPageObjects(IWebDriver driver){
        this.driver = driver;
    }

    // Landing page elements

    public IWebElement LanguageButton => driver.FindElement(By.Id("topActionSwitchLang"));
    public IWebElement LoginButton => driver.FindElement(By.Id("anonLogin"));
    public IWebElement SignUpButton => driver.FindElement(By.Id("anonSignup"));

    // Lang
    public IWebElement EnglishLanguageButton => driver.FindElement(By.CssSelector("div.lzd-switch-item[data-lang='en']"));
    public IWebElement BanglaLanguageButton => driver.FindElement(By.CssSelector("div.lzd-switch-item[data-lang='bn']"));

    public IWebElement SearchInputField => driver.FindElement(By.Name("q"));
    public IWebElement SearchFieldPlaceHolderEN => driver.FindElement(By.XPath("//input[@placeholder='Search in Daraz']"));
    public IWebElement SearchFieldPlaceHolderBN => driver.FindElement(By.XPath("//input[@placeholder='দারাজ এ অনুসন্ধান']"));

}

		
}

