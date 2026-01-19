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
        Console.WriteLine(" Execution Started !!!");
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

    [Test]
    public void DropdownTest()
    {
        driver.Navigate().GoToUrl("https://www.google.com");
        driver.FindElement(By.Name("q")).SendKeys("Banglagesh");

        //SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("")));
        Assert.Pass();


    }

    [TearDown]
    public void CloseDriver()
    {
        // Driver quit
        driver.Quit();
    }

}
