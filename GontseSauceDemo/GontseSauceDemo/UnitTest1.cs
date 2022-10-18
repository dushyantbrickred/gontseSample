using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GontseSauceDemo
{
    public class Tests
    {

        IWebDriver Driver; 
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Driver.FindElement(By.Id("user-name"));
            Driver.FindElement(By.Id("password"));
            Assert.Pass();
        }
    }
}