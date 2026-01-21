using System;
using OpenQA.Selenium;

namespace AutomationTask.Pages
{
    public class CartPageObjects
    {
        private readonly IWebDriver driver;

        public CartPageObjects(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By SelectAllCheckBox => By.XPath("(//label[contains(@class,'next-checkbox')])[1]");
        public By DeleteButton => By.XPath("//span [text()='Delete']");
        public By RemoveButton => By.XPath("//button [text()='REMOVE']");
        public By NoItemInCartText => By.ClassName("cart-empty-text");

        //Total
        public By CartTotalAmount => By.XPath("//div[contains(text(),'৳')]");
        public By OrderConfirmTotalAmount=> By.XPath("//div[contains(text(),'৳')]");

        public By CheckoutButton => By.XPath("//button[contains(text(),'PROCEED')]");
        public By ProceedToPayButton => By.XPath("//div[text()='Proceed to Pay']");


        //div[contains(text(),'৳')]






    }
}

