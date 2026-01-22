using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AutomationTask.Utility;
using System.IO;

namespace AutomationTask.Config
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected ExtentTest extentTest;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            ExtentReporterHelper.InitReport();
        }

        [SetUp]
        public void Setup()
        {
            extentTest = ExtentReporterHelper.CreateTest(
                TestContext.CurrentContext.Test.Name
            );

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(TestData.LandingPageUrl);

            extentTest.Info("Browser launched and URL opened");
        }

        [TearDown]
        public void TearDown()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;

            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                string screenshot = TakeScreenshot();
                extentTest.Fail("Test Failed")
                          .AddScreenCaptureFromPath(screenshot);
            }
            else
            {
                extentTest.Pass("Test Passed");
            }

            driver.Quit();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            ExtentReporterHelper.FlushReport();
        }

        private string TakeScreenshot()
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();

            string path = Path.Combine(
                TestContext.CurrentContext.WorkDirectory,
                "Reports",
                "Screenshots"
            );

            Directory.CreateDirectory(path);

            string filePath = Path.Combine(
                path,
                $"{TestContext.CurrentContext.Test.Name}.png"
            );

            screenshot.SaveAsFile(filePath);
            return filePath;
        }
    }
}

