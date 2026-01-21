using System;
using Allure.NUnit.Attributes;
using AutomationTask.Config;
using AutomationTask.Tests.UserLogin;

namespace AutomationTask.Tests.Product.ProductAddToCart
{
    [TestFixture]
    [Category("Smoke")]
    [Category("Product AddToCart")]
    [AllureSuite("Product")]
    [AllureEpic("Validate User Able to Login")]
    public class ProductAddToCartTests: BaseTest 
	{
        [Test]
        [Description("Validate that user can Login and able to Add products in Cart")]
        [AllureFeature("Validate that user can Login and able to Add products in Cart")]
        public void ValidateProductAddToCartTests()
		{
            UserLoginActions userLoginActions = new UserLoginActions(driver);
            ProductAddToCartActions productAddToCartActions = new ProductAddToCartActions(driver);

            userLoginActions.ValidateUserAbleToLogin();
            productAddToCartActions.ValidateUserAbleToAddProductToCartAndCartClean();

        }
    }
}

