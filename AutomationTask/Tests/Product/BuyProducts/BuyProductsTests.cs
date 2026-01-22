using System;
//using Allure.NUnit.Attributes;
using AutomationTask.Config;
using AutomationTask.Tests.Product.ProductAddToCart;
using AutomationTask.Tests.UserLogin;
namespace AutomationTask.Tests.Product.BuyProducts
{
    [TestFixture]
    [Category("Smoke")]
    [Category("LoginAddToCartBuyProduct")]
    //[AllureSuite("Product")]
    //[AllureEpic("Validate User Able to Buy Product")]

    public class BuyProductsTests: BaseTest
    {
        [Test]
        [Description("Validate that user can Login and able to Add to cart and purchase products")]
        //[AllureFeature("Validate that user can Login and able to Add to cart and purchase products")]

        public void ValidateBuyProductsTests(){
            UserLoginActions userLoginActions = new UserLoginActions(driver);
            ProductAddToCartActions productAddToCartActions = new ProductAddToCartActions(driver);
            BuyProductsActions buyProductsActions = new BuyProductsActions(driver);

            userLoginActions.ValidateUserAbleToLogin();
            productAddToCartActions.ValidateUserAbleToAddProductToCart();
            buyProductsActions.VerifyUserAbleToPlaceOrder();
            extentTest.Info("User able to Login and able to Add to cart and purchase products");
        }
    }
}