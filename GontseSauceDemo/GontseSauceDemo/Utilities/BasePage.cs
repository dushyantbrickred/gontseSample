using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GontseSauceDemo.Utilities
{
    public abstract class BasePage : BrowserablePage
    {
        public string Title
        {
            get
            {
                return BrowserInfo.Current.Title;
            }
        }

        [Obsolete]
        public virtual void OnPageLoad()
        {
            BrowserInfo.Current.Manage().Window.Maximize();
            //(BrowserInfo.Current as IJavaScriptExecutor).ExecuteScript("if (typeof jQuery !== 'undefined') $.fx.off = true;");
        }
        public abstract bool IsValid();
    }
}
