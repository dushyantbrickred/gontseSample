using System;
using GontseSauceDemo.Pages;
using GontseSauceDemo.Utilities;
using TechTalk.SpecFlow;

namespace GontseSauceDemo
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given(@"\[User  navigates to URL]")]
        public void GivenUserNavigatesToURL()
        {
            BrowserInfo.NavigateToPage<LoginPage>();
        }

        [When(@"\[User enters username and password and clicks login]")]
        public void WhenUserEntersUsernameAndPasswordAndClicksLogin()
        {
            BrowserInfo.NewCurrentPage<LoginPage>().EnterUsernameAndPassword();
        }

        [Then(@"\[Product Page should be displayed]")]
        public void ThenProductPageShouldBeDisplayed()
        {
            BrowserInfo.NewCurrentPage<Products>().IsValid();
        }
    }
}
