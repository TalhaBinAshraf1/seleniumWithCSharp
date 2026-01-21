using System;
using OpenQA.Selenium;

namespace AutomationTask.Pages
{
	public class RegisterPageObjects
	{
        private readonly IWebDriver driver;

        public RegisterPageObjects(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By HeaderTextCreateAccount => By.XPath("//h3[contains(text(),'Create your Daraz Account')]");
        public By PhoneNumberField => By.XPath("//input[contains(@placeholder,'Enter your phone number')]");
        public By SMSVerificationField => By.XPath("//input[contains(@placeholder, '6 digits')]");
        public By PasswordField => By.XPath("//input[contains(@placeholder,'Minimum 6 characters')]");
        public By FullNameField => By.XPath("//input[contains(@placeholder,'First Last')]");
        public By PromotionSMSCheckbox => By.XPath("//label[contains(@class,'next-checkbox')]");
        public By SignUpButton => By.XPath("//button[contains(text(),'SIGN UP')]");

        //Dropdown
        public By Month => By.Id("month");
        public By MonthValue => By.XPath("//li[contains(text(),'July')]");
        public By Day => By.Id("day");
        public By DayValue => By.XPath("//li[contains(text(),'08')]");
        public By Year => By.Id("year");
        public By YearValue => By.XPath("//li[contains(text(),'1996')]");
        public By Gender => By.Id("gender");
        public By GenderValue => By.XPath("//li[text()='male']");



    }
}

