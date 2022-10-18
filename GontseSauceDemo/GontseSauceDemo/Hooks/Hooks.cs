using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GontseSauceDemo.Utilities;
using TechTalk.SpecFlow;

namespace GontseSauceDemo.Hooks
{
    public class Hooks
    {
        [AfterTestRun]
        public static void AfterTestRun()
        {
            BrowserInfo.Current.Quit();
            BrowserInfo.Current.Dispose();
        }
    }
}
