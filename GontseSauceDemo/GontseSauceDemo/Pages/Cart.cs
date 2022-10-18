using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GontseSauceDemo.Utilities;
using OpenQA.Selenium;

namespace GontseSauceDemo.Pages
{
    public class Cart : BasePage
    {
        private readonly By CART = By.Id("cart_contents_container");
        private readonly By CHECKOUT = By.Id("checkout");
        private readonly By REMOVE_BACKPACK_BTN = By.Id("remove-sauce-labs-backpack");
        private readonly By REMOVE_BOLT_SHIRT_BTN = By.Id("remove-sauce-labs-bolt-t-shirt");
        private readonly By REMOVE_BIKE_LIGHT_BTN = By.Id("remove-sauce-labs-bike-light");
        private readonly By REMOVE_FLEECE_JACKET_BTN = By.Id("remove-sauce-labs-fleece-jacket");
        private readonly By REMOVE_ONESIE_BTN = By.Id("remove-sauce-labs-onesie");
        private readonly By REMOVE_ALL_THINGS_SHIRT_BTN = By.Id("remove-test.allthethings()-t-shirt-(red)");
        public override bool IsValid()
        {
            return BrowserInfo.WaitForElement(CART, 20) != null;
        }
        public void ClickCheckOut()
        {
            BrowserInfo.Current.FindElement(CHECKOUT).Click();
        }
        public void RemoveFromCart(string Item)
        {
            switch (Item)
            {
                case "backpack":
                    BrowserInfo.Current.FindElement(REMOVE_BACKPACK_BTN).Click();
                    break;
                case "bikelight":
                    BrowserInfo.Current.FindElement(REMOVE_BIKE_LIGHT_BTN).Click();
                    break;

                case "boltshirt":
                    BrowserInfo.Current.FindElement(REMOVE_BOLT_SHIRT_BTN).Click();
                    break;

                case "fleecejacket":
                    BrowserInfo.Current.FindElement(REMOVE_FLEECE_JACKET_BTN).Click();
                    break;

                case "onesie":
                    BrowserInfo.Current.FindElement(REMOVE_ONESIE_BTN).Click();
                    break;

                case "testall":
                    BrowserInfo.Current.FindElement(REMOVE_ALL_THINGS_SHIRT_BTN).Click();
                    break;
                default: throw new ArgumentOutOfRangeException();
            }
        }

    }
}
