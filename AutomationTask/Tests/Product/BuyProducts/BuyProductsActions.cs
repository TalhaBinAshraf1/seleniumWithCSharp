using System;
using AutomationTask.Pages;
using AutomationTask.Utils;
using OpenQA.Selenium;
using System.Text.RegularExpressions;
using AutomationTask.Tests.Product.ProductAddToCart;

namespace AutomationTask.Tests.Product.BuyProducts
{
	public class BuyProductsActions
	{
        private readonly IWebDriver driver;
        private readonly UtilityActions utility;
        private CartPageObjects cartPageObjects;
        private readonly ProductAddToCartActions productAddToCartActions;

        public BuyProductsActions(IWebDriver driver)
        {
            this.driver = driver;
            utility = new UtilityActions(driver);
            cartPageObjects = new CartPageObjects(driver);
            productAddToCartActions = new ProductAddToCartActions(driver);
        }

        public void VerifyTotalAmountInCartToConfirmOrderPage() {
            utility.Click(cartPageObjects.SelectAllCheckBox);
            Thread.Sleep(2000);
            string totalAmountInCartPage = utility.GetText(cartPageObjects.CartTotalAmount);
            Console.WriteLine("Cart Page Data >>>> " + totalAmountInCartPage);
            Thread.Sleep(2000);
            utility.Click(cartPageObjects.CheckoutButton);
            Thread.Sleep(2000);
            string totalAmountInOrderConfirmPage = utility.GetText(cartPageObjects.OrderConfirmTotalAmount);
            string totalAmountInOrderConfirmPageFiltered =Regex.Match(totalAmountInOrderConfirmPage, @"৳\s?[\d,]+").Value;
            Console.WriteLine("Confirm Page Data >>>> " + totalAmountInOrderConfirmPageFiltered);
            Assert.That(totalAmountInCartPage, Is.EqualTo(totalAmountInOrderConfirmPageFiltered));
        }

        public void ClickOnProcedToPay()
        {
            utility.Click(cartPageObjects.ProceedToPayButton);
        }

        public void ClearTheCart() {
            driver.Navigate().GoToUrl(Utility.TestData.CartPageUrl);
            productAddToCartActions.VerifyUserCanCleanTheCart();
        }


        public void VerifyUserAbleToPlaceOrder()
        {
            VerifyTotalAmountInCartToConfirmOrderPage();
            //ClickOnProcedToPay();
            ClearTheCart();
        }

    }
}

