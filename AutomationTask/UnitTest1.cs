using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationTask;

public class Tests
{
    IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        // connection
        driver = new ChromeDriver();
        // Maximize the Window
        driver.Manage().Window.Maximize();
    }

    [Test]
    public void Test1()
    {

        // Navigation
        driver.Navigate().GoToUrl("https://www.daraz.com.bd/");

        // 
        IWebElement searchInputField = driver.FindElement(By.Name("q"));
        searchInputField.SendKeys("Selenium");
        searchInputField.SendKeys(Keys.Enter);

        //Simple Assertions
        Assert.Pass();
    }

    //[Test]
    //public void DropwodnTest() {

    //    //SelectElement = ctElement(driver.FindElement(By.CssSelector(""));



    //}

    [TearDown]
    public void CloseDriver()
    {
        // Driver quit
        driver.Quit();
    }

}
