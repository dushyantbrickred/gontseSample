using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GontseSauceDemo.Utilities;
using OpenQA.Selenium;

namespace GontseSauceDemo.Pages
{
    public  class LoginPage : BasePage
    {
        private readonly string _url = "https://www.saucedemo.com/";
        private readonly By USERNAME = By.Id("user-name");
        private readonly By PASSWORD = By.Id("password");
        private readonly By LOGIN_BTN = By.Id("login-button");


        public override string URL
        {
            get
            {
                return _url;
            }
        }
        public override bool IsValid()
        {
            return BrowserInfo.WaitForElement(USERNAME, 20) != null;
        }
        public void EnterUsernameAndPassword()
        {
            BrowserInfo.Current.FindElement(USERNAME).SendKeys("standard_user");
            BrowserInfo.Current.FindElement(PASSWORD).SendKeys("secret_sauce");
            BrowserInfo.Current.FindElement(LOGIN_BTN).Click();
        }

    }
}
