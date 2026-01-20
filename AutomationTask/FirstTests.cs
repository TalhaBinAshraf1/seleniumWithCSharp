using AutomationTask.Config;
using AutomationTask.Pages;
using AutomationTask.Tests.Language;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationTask;

public class FirstTests : BaseTest
{
    //IWebDriver driver;

    //[SetUp]
    //public void Setup()
    //{
    //    // connection
    //    driver = new ChromeDriver();
    //    // Maximize the Window
    //    driver.Manage().Window.Maximize();
    //    Console.WriteLine(" Execution Started !!!");
    //}

    //[Test]
    //[Description("Validate the navigation")]
    //public void Test1()
    //{

    //    // Navigation
    //    //driver.Navigate().GoToUrl("https://www.daraz.com.bd/");

    //    // 
    //    //IWebElement searchInputField = driver.FindElement(By.Name("q"));

    //    //Pulling Only Objects 
    //    //LandingPageObjects landingPageObjects = new LandingPageObjects(driver);
    //    //landingPageObjects.SearchInputField.SendKeys("Selenium");
    //    //landingPageObjects.SearchInputField.SendKeys(Keys.Enter);

    //    LanguageActions languageActions = new LanguageActions(driver);

    //    languageActions.searchOnSearchber();

    //    //searchInputField.SendKeys("Selenium");
    //    //searchInputField.SendKeys(Keys.Enter);

    //    //Simple Assertions
    //    Assert.Pass();
    //}

    //[Test]
    //public void DropdownTest()
    //{
    //    driver.Navigate().GoToUrl("https://www.google.com");
    //    driver.FindElement(By.Name("q")).SendKeys("Banglagesh");

    //    //SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("")));
    //    Assert.Pass();
    //}    

    //[TearDown]
    //public void CloseDriver()
    //{
    //    // Driver quit
    //    driver.Quit();
    //}

}
