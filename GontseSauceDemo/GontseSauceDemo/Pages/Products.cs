using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GontseSauceDemo.Utilities;
using OpenQA.Selenium;

namespace GontseSauceDemo.Pages
{
    internal class Products : BasePage
    {
        private readonly By INVENTORY = By.Id("inventory_container");
        private readonly By SAUCE_LABS_BACKPACK_ADD_BTN = By.Id("add-to-cart-sauce-labs-backpack");
        private readonly By SAUCE_LABS_BIKE_LIGHT_ADD_BTN = By.Id("add-to-cart-sauce-labs-bike-light");
        private readonly By SAUCE_LABS_BOLT_SHIRT_ADD_BTN = By.Id("add-to-cart-sauce-labs-bolt-t-shirt");
        private readonly By SAUCE_LABS_FLEECE_JACKET_ADD_BTN = By.Id("add-to-cart-sauce-labs-fleece-jacket");
        private readonly By SAUCE_LABS_ONESIE_ADD_BTN = By.Id("add-to-cart-sauce-labs-onesie");
        private readonly By SAUCE_LABS_TEST_ALL_ADD_BTN = By.Id("add-to-cart-test.allthethings()-t-shirt-(red)");
        private readonly By SHOPPING_CART = By.Id("shopping_cart_container");
        public override bool IsValid()
        {
            return BrowserInfo.WaitForElement(INVENTORY, 20) != null;
        }
        public void AddToCart(string product)
        {
            switch (product)
            {
                case "backpack":
                    BrowserInfo.Current.FindElement(SAUCE_LABS_BACKPACK_ADD_BTN).Click();
                    break;
                case "bikelight":
                    BrowserInfo.Current.FindElement(SAUCE_LABS_BIKE_LIGHT_ADD_BTN).Click();
                    break;

                case "boltshirt":
                    BrowserInfo.Current.FindElement(SAUCE_LABS_BOLT_SHIRT_ADD_BTN).Click();
                    break;

                case "fleecejacket":
                    BrowserInfo.Current.FindElement(SAUCE_LABS_FLEECE_JACKET_ADD_BTN).Click();
                    break;

                case "onesie":
                    BrowserInfo.Current.FindElement(SAUCE_LABS_ONESIE_ADD_BTN).Click();
                    break;

                case "testall":
                    BrowserInfo.Current.FindElement(SAUCE_LABS_TEST_ALL_ADD_BTN).Click();
                    break;
                default: throw new ArgumentOutOfRangeException();
            }
        }
        public void ClickOnCart()
        {
            BrowserInfo.Current.FindElement(SHOPPING_CART).Click();
        }
    }
}
