using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using RetconShoppingProject.BrowserFactory;

namespace RetconShoppingProject.Hookes
{
    [TestClass]
    public class CartHookes
 
    {
        private IWebDriver _driver;
        private Browser _browser;

        [TestInitialize]
        public void StartTest()
        {
            _browser = new Browser();
            _driver = _browser
                .InitializeBrowser()
                .SetupBrowser();
        }

        [TestCleanup]
        public void ShutDownTest()
        {
            _browser.CloseBrowser();
        }

    }
}

