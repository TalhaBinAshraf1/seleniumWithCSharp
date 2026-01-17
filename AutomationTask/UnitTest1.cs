
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

    [TearDown]
    public void CloseDriver()
    {
        // Driver close
        driver.Quit();
    }
}
