using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationTask.Utils
{
    public class UtilityActions
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public UtilityActions(IWebDriver driver, int timeout = 10)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
        }

        public IWebElement WaitForElementVisible(By locator)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public IWebElement WaitForElementClickable(By locator)
        {
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public void Click(By locator)
        {
            WaitForElementClickable(locator).Click();
        }

        public void Type(By locator, string text)
        {
            var element = WaitForElementVisible(locator);
            element.Clear();
            element.SendKeys(text);
        }

        public string GetText(By locator)
        {
            return WaitForElementVisible(locator).Text;
        }

        public string GetAttribute(By locator, string attributeName)
        {
            return WaitForElementVisible(locator).GetAttribute(attributeName);
        }

        public void WaitForAttributeValue(By locator, string attribute, string expectedValue)
        {
            wait.Until(driver =>
                driver.FindElement(locator).GetAttribute(attribute) == expectedValue
            );
        }
    }
}
