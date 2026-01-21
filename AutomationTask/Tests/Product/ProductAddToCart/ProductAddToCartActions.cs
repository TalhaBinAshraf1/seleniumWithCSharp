using System;
using AutomationTask.Pages;
using AutomationTask.Utils;
using OpenQA.Selenium;

namespace AutomationTask.Tests.Product.ProductAddToCart
{
	public class ProductAddToCartActions
	{
        private readonly IWebDriver driver;
        private readonly UtilityActions utility;
        private readonly ProductObjects productObjects;
        private CartPageObjects cartPageObjects;

        public ProductAddToCartActions(IWebDriver driver)
        {
            this.driver = driver;
            utility = new UtilityActions(driver);
            productObjects = new ProductObjects(driver);
            cartPageObjects = new CartPageObjects(driver);
        }

        public void ClickOnCatagory() {
            utility.Click(productObjects.ProductCatagory);
        }

        public void SelectACatagory()
        {
            utility.Click(productObjects.WomanProductCategory);
            utility.Click(productObjects.BagSubCategory);
        }

        public void ValidateSubCategoryHeadertext() {
            string Text = utility.GetText(productObjects.SubCategoryHeaderText);
            Assert.That(Text, Is.EqualTo("Bags"));
        }

        public void VerifyUserCanAddToCartACatagoryProduct() {
            utility.Click(productObjects.FirstProductOfThePage);
            string ProductTitleInProductPage = utility.GetText(productObjects.ProductTitle);
            utility.Click(productObjects.AddtoCartButton);
            string SucessFullText = utility.GetText(productObjects.AddToCartSucessfulText);
            Assert.That(SucessFullText, Is.EqualTo("Added to cart successfully!"));
            utility.Click(productObjects.CrossButton);
            utility.Click(productObjects.CartIcon);
            string ProductTitleInCartPage = utility.GetText(productObjects.FirstProductTitleInCart);
        }

        public void SelectAnotherCatagory()
        {
            utility.Click(productObjects.ManProductCategory);
            utility.Click(productObjects.ShoesSubCategory);
        }

        public void ValidateAnotherSubCategoryHeadertext()
        {
            string Text = utility.GetText(productObjects.SubCategoryHeaderText);
            Assert.That(Text, Is.EqualTo("Shoes"));
        }

        public void VerifyUserCanAddToCartAnotherCatagoryProduct()
        {
            utility.Click(productObjects.FirstProductOfThePage);
            string ProductTitleInProductPage = utility.GetText(productObjects.ProductTitle);
            utility.Click(productObjects.AddtoCartButton);
            string SucessFullText = utility.GetText(productObjects.AddToCartSucessfulText);
            Assert.That(SucessFullText, Is.EqualTo("Added to cart successfully!"));
            utility.Click(productObjects.CrossButton);
            utility.Click(productObjects.CartIcon);
            string ProductTitleInCartPage = utility.GetText(productObjects.SecondProductTitleInCart);
        }

        public void VerifyUserCanCleanTheCart() {
            utility.Click(cartPageObjects.SelectAllCheckBox);
            utility.Click(cartPageObjects.DeleteButton);
            utility.Click(cartPageObjects.RemoveButton);

            string Text = utility.GetText(cartPageObjects.NoItemInCartText);
            Assert.That(Text, Is.EqualTo("There are no items in this cart"));

        }


        //Combine Method
        public void ValidateUserAbleToAddProductToCart()
        {
            ClickOnCatagory();
            SelectACatagory();
            ValidateSubCategoryHeadertext();
            VerifyUserCanAddToCartACatagoryProduct();
            ClickOnCatagory();
            SelectAnotherCatagory();
            ValidateAnotherSubCategoryHeadertext();
            VerifyUserCanAddToCartAnotherCatagoryProduct();
        }

        public void ValidateUserAbleToAddProductToCartAndCartClean()
        {
            ClickOnCatagory();
            SelectACatagory();
            ValidateSubCategoryHeadertext();
            VerifyUserCanAddToCartACatagoryProduct();
            ClickOnCatagory();
            SelectAnotherCatagory();
            ValidateAnotherSubCategoryHeadertext();
            VerifyUserCanAddToCartAnotherCatagoryProduct();
            VerifyUserCanCleanTheCart();
        }

    }
}

