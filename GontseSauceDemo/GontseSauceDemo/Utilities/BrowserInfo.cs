    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TechTalk.SpecFlow;

namespace GontseSauceDemo.Utilities
{
    internal class BrowserInfo
    {
        public static FeatureContext _featureContext;

        public static void SetCurrentFeatureContext(FeatureContext featureContext)
        {
            BrowserInfo._featureContext = featureContext;
        }
        public static IWebDriver Current
        {
            get
            {
                if (!_featureContext.ContainsKey("browser"))
                {
                    IWebDriver driver = null;

                    var proxy = new Proxy { IsAutoDetect = true };

                    var ChromeOptions = new ChromeOptions();

                    driver = new ChromeDriver(ChromeOptions);

                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
                    _featureContext["browser"] = driver;
                }
                return (IWebDriver)_featureContext["browser"];
            }
        }
        public static T NavigateToPage<T>() where T : BasePage, new()
        {
            var page = new T();
            page.OnPageLoad();

            Current.Navigate().GoToUrl(page.URL);

            try
            {
                if (page.IsValid())
                {
                    _featureContext["currentPage"] = page;
                    return page;
                }
            }
            catch { }
            Console.WriteLine("Attempt 2 at Navigate");

            return page;
        }

        
        public static T NewCurrentPage<T>() where T : BasePage, new()
        {
            var page = new T();
            page.OnPageLoad();

            _featureContext["currentPage"] = page;

            return page;
        }

        public static T GetCurrentPage<T>() where T : BasePage
        {
            var currentPage = _featureContext["currentPage"] as T;
            return currentPage;
        }
        public static IWebElement WaitForElement(By by, int timeoutInSeconds = 20)
        {
            var wait = new WebDriverWait(Current, TimeSpan.FromSeconds(timeoutInSeconds));

            var waitUntilExpectedCondition = ExpectedConditions.ElementIsVisible(by);

            wait.Message = "Could not find element " + by.ToString();

            var result = wait.Until(waitUntilExpectedCondition);

            return result;
        }
        public static void SetValue<T>(string scenario, string key, T value)
        {
            _featureContext.Add(scenario + "|" + key, value);
        }
        public static T GetValue<T>(string scenario, string key) where T : class
        {
            var uniqueKey = scenario + "|" + key;
            if(!_featureContext.ContainsKey(uniqueKey))
            {
                return default(T);
            }
            return _featureContext[uniqueKey] as T;
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Current.Quit();
            Current.Dispose();
            _featureContext.Remove("Browser");
        }
    }
}
