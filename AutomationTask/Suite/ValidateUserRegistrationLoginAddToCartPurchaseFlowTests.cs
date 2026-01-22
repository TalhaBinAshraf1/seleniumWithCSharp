using System;
using NUnit.Framework.Internal;
using NUnit.Framework;
using AutomationTask.Config;
using AutomationTask.Tests.Language;
using AutomationTask.Tests.Product.BuyProducts;
using AutomationTask.Tests.Product.ProductAddToCart;
using AutomationTask.Tests.UserLogin;
using AutomationTask.Tests.UserRegistration;

namespace AutomationTask.Tests.E2E
{
    [TestFixture]
    [Category("E2E")]
    [NonParallelizable]
    public class ValidateLanguageChangeUserRegistrationLoginAddToCartPurchaseFlowTests : BaseTest
    {
        [Test, Order(1)]
        public void ChangeLanguage()
        {
            new LanguageActions(driver).VerifyLanguageChangeEnglishToBangla();
            new LanguageActions(driver).VerifyLanguageChangeBanglaToEnglish();
            extentTest.Info("User able to change Lanuage Sucessfully");
        }

        [Test, Order(2)]
        public void UserRegistration()
        {
            new UserRegistrationActions(driver).ValidateUserAbleToRegisterSucessfully();
            extentTest.Info("User can Register with PhoneNumber");
        }

        [Test, Order(3)]
        public void UserLogin()
        {
            new UserLoginActions(driver).ValidateUserAbleToLogin();
            extentTest.Info("User can Login with PhoneNumber");
        }

        [Test, Order(4)]
        public void AddProductToCart()
        {
            new UserLoginActions(driver).ValidateUserAbleToLogin();
            new ProductAddToCartActions(driver).ValidateUserAbleToAddProductToCartAndCartClean();
            extentTest.Info("User able to Login and able to Add products in Cart");
        }

        [Test, Order(5)]
        public void BuyProduct()
        {
            new UserLoginActions(driver).ValidateUserAbleToLogin();
            new ProductAddToCartActions(driver).ValidateUserAbleToAddProductToCart();
            new BuyProductsActions(driver).VerifyUserAbleToPlaceOrder();
            extentTest.Info("User able to Login and able to Add to cart and purchase products");
        }
    }
}

