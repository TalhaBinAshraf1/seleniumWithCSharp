using System;
using OpenQA.Selenium;

namespace AutomationTask.Pages
{
	public class LandingPageObjects
	{
        private readonly IWebDriver driver;

        // Constructor assisn as field
        public LandingPageObjects(IWebDriver driver) {

            this.driver = driver;
        }

        // Landing page elements
        public IWebElement SearchInputField => driver.FindElement(By.Name("q"));

        public IWebElement Password => driver.FindElement(By.Id("password"));

        public IWebElement LoginButton => driver.FindElement(By.CssSelector("button[type='submit']"));

        public IWebElement SuccessMessage => driver.FindElement(By.Id("flash"));
    }
}

