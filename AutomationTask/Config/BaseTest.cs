using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace AutomationTask.Config
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void beforeTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Utils.TestData.LandingPageUrl);
        }

        [TearDown]
        public void afterTest()
        {
            driver.Quit();
        }
    }
}
