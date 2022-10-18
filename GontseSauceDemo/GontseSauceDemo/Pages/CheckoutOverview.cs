using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GontseSauceDemo.Utilities;
using OpenQA.Selenium;

namespace GontseSauceDemo.Pages
{
    public class CheckoutOverview : BasePage
    {

        private readonly By CHECKOUT_SUMMART = By.Id("checkout_summary_container");
        private readonly By FINISH_BUTTON = By.Id("finish");

        public override bool IsValid()
        {
            return BrowserInfo.WaitForElement(CHECKOUT_SUMMART, 20) != null;
        }
        public void ClickFinish()
        {
            BrowserInfo.Current.FindElement(FINISH_BUTTON).Click();
        }
    }
}
