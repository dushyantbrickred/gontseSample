using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GontseSauceDemo.Utilities;
using OpenQA.Selenium;

namespace GontseSauceDemo.Pages
{
    public class CheckOutComplete : BasePage
    {
        private readonly By CHECKOUT_COMPLETE = By.Id("checkout_complete_container");
        private readonly By BACK_TO_PRODUCTS = By.Id("back-to-products");

        public override bool IsValid()
        {
            return BrowserInfo.WaitForElement(CHECKOUT_COMPLETE, 20) != null;
        }
    }
}
