using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Allure.Commons;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System;

namespace AutomationTask.Config
{

    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void BeforeTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Utility.TestData.LandingPageUrl);
        }

        [TearDown]
        public void AfterTest()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                TakeScreenshot();
            }
            driver.Quit();
        }


        private void TakeScreenshot()
        {
            try
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var bytes = screenshot.AsByteArray;

                AllureLifecycle.Instance.AddAttachment(
                    "Failure Screenshot",
                    "image/png",
                    bytes);
            }
            catch (Exception)
            {
                //Console.WriteLine("Allure Not Generated !!");
            }
        }
    }
}
