using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GontseSauceDemo.Utilities;
using OpenQA.Selenium;

namespace GontseSauceDemo.Pages
{
    public class CheckoutInfo : BasePage
    {
        private readonly By CHECKOUT_INFO = By.Id("checkout_info_container");
        private readonly By CONTINUE_BUTTON = By.Id("continue");
        private readonly By FIRSTNAME = By.Id("first-name");
        private readonly By LASTNAME = By.Id("last-name");
        private readonly By ZIP = By.Id("postal-code");
        private readonly By CANCEL_BTN = By.Id("cancel");
        public override bool IsValid()
        {
            return BrowserInfo.WaitForElement(CHECKOUT_INFO, 20) != null;
        }
        public void ClickContinue()
        {
            BrowserInfo.Current.FindElement(CONTINUE_BUTTON).Click();
        }
        public void EnterCheckOutInformation(string firstname, string lastname, string zipCode)
        {
            var nametxtBx = BrowserInfo.Current.FindElement(FIRSTNAME);
            nametxtBx.Click();
            nametxtBx.SendKeys(firstname);

            var lastnametxtBx = BrowserInfo.Current.FindElement(LASTNAME);
            lastnametxtBx.Click();
            lastnametxtBx.SendKeys(lastname);

            var zipBx = BrowserInfo.Current.FindElement(ZIP);
            zipBx.Click();
            zipBx.SendKeys(zipCode);
        }
    }
}
