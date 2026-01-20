using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationTask.Utils
{
    public class UtilityActions
    {
        private readonly IWebDriver driver;

       public UtilityActions(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitForElementVisible(By locator, int timeout = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public void Click(By locator)
        {
            WaitForElementVisible(locator);
            driver.FindElement(locator).Click();
        }

        public void Type(By locator, string text)
        {
            WaitForElementVisible(locator);
            var element = driver.FindElement(locator);
            element.Clear();
            element.SendKeys(text);
        }

        public string GetText(By locator)
        {
            WaitForElementVisible(locator);
            return driver.FindElement(locator).Text;
        }
    }

}