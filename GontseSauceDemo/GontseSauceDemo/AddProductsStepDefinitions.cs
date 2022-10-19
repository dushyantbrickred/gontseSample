using System;
using FluentAssertions;
using GontseSauceDemo.Pages;
using GontseSauceDemo.Utilities;
using TechTalk.SpecFlow;

namespace GontseSauceDemo
{
    [Binding]
    public class AddProductsStepDefinitions
    {
        private const string scenarioName = "AddProducts";
        private const string addeddProductKey = "key";


        public AddProductsStepDefinitions(FeatureContext featureContext)
        {
            BrowserInfo.SetCurrentFeatureContext(featureContext);
        }

        [Given(@"\[User Is Logged On]")]
        public void GivenUserIsLoggedOn()
        {
            BrowserInfo.NavigateToPage<LoginPage>();
            BrowserInfo.NewCurrentPage<LoginPage>().EnterUsernameAndPassword();
            var isProductPageDisplayed = BrowserInfo.NewCurrentPage<Products>().IsValid();
            isProductPageDisplayed.Should().BeTrue();
        }
        [When(@"\[User adds <""([^""]*)""> to cart]")]
        public void WhenUserAddsToCart(string product)
        {
            BrowserInfo.GetCurrentPage<Products>().AddToCart(product);
            BrowserInfo.SetValue(scenarioName, product, product);
        }


        [When(@"\[User clicks on cart]")]
        public void WhenUserClicksOnCart()
        {
            BrowserInfo.GetCurrentPage<Products>().ClickOnCart();
        }

        [Then(@"\[Cart Page Should be displayed]")]
        public void ThenCartPageShouldBeDisplayed()
        {
            var isCartPageDisaplayed = BrowserInfo.NewCurrentPage<Cart>().IsValid();
            isCartPageDisaplayed.Should().BeTrue();
        }

        [When(@"\[User clicks on checkout]")]
        public void WhenUserClicksOnCheckout()
        {
            BrowserInfo.GetCurrentPage<Cart>().ClickCheckOut();
        }

        [Then(@"\[Checkout Information is Displayed]")]
        public void ThenCheckoutInformationIsDisplayed()
        {
            var isCheckOutInformationPageDisplayed = BrowserInfo.NewCurrentPage<CheckoutInfo>().IsValid();
            isCheckOutInformationPageDisplayed.Should().BeTrue();
        }

        [Then(@"\[User enters <""([^""]*)"">, <""([^""]*)"">, <""([^""]*)"">]")]
        public void ThenUserEnters(string firstName, string lastname, string zipCode)
        {
            BrowserInfo.GetCurrentPage<CheckoutInfo>().EnterCheckOutInformation(firstName, lastname, zipCode);
        }

        [When(@"\[User Clicks Continue]")]
        public void WhenUserClicksContinue()
        {
            BrowserInfo.GetCurrentPage<CheckoutInfo>().ClickContinue();
        }

        [Then(@"\[Checkout Overview Page is Displayed]")]
        public void ThenCheckoutOverviewPageIsDisplayed()
        {
           var isCheckoutOverviewDisplayed = BrowserInfo.NewCurrentPage <CheckoutOverview>().IsValid();
            isCheckoutOverviewDisplayed.Should().BeTrue();
        }
        [Then(@"\[User Clicks Finish]")]
        public void ThenUserClicksFinish()
        {
            BrowserInfo.GetCurrentPage<CheckoutOverview>().ClickFinish();
        }
        [Then(@"\[User removes <""([^""]*)"">]")]
        public void ThenUserRemoves(string boltshirt)
        {
            BrowserInfo.GetValue<Cart>(scenarioName, boltshirt).ToString();
            BrowserInfo.GetCurrentPage<Cart>().RemoveFromCart(boltshirt);
        }
    }
}
