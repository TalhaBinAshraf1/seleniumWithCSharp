using System;
using OpenQA.Selenium;

namespace AutomationTask.Pages
{
    public class ProductObjects
    {
        private readonly IWebDriver driver;

        public ProductObjects(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By ProductCatagory=> By.XPath("//span[text()='Categories']");
        public By WomanProductCategory => By.XPath("//span[contains(text(),\"Women's & Girls' Fashion\")]");
        public By BagSubCategory => By.XPath("(//li[contains(@class,'lzd-site-menu-sub-item')]//span[normalize-space()='Bags'])[1]");
        public By SubcatagoryText => By.XPath("");
        public By SubCategoryHeaderText => By.XPath("//h1");
        public By FirstProductOfThePage => By.CssSelector("div[data-qa-locator='product-item']:nth-of-type(1)");

        public By AddtoCartButton => By.XPath("//span[text()='Add to Cart']");
        public By ProductTitle => By.XPath("//h1[contains(@class,'pdp-mod-product-badge-title')]");
        public By AddToCartSucessfulText => By.ClassName("cart-message-text");
        public By CrossButton => By.CssSelector("a.next-dialog-close");

        public By CartIcon => By.ClassName("lzd-nav-cart");
        public By FirstProductTitleInCart => By.XPath("(//a[contains(@class,'automation-link-from-title-to-prod') and contains(@class,'title')])[1]");
        public By SecondProductTitleInCart => By.XPath("(//a[contains(@class,'automation-link-from-title-to-prod') and contains(@class,'title')])[2]");

        //Another Catagory
        public By ManProductCategory => By.XPath("//span[contains(text(),\"Men's & Boys' Fashion\")]");
        public By ShoesSubCategory => By.XPath("(//li[contains(@class,'lzd-site-menu-sub-item')]//span[normalize-space()='Shoes'])[2]");



    }
}

