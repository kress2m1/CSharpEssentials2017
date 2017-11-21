using System;
using Com.ShoppingCart.Project.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Com.ShoppingCart.Project.Tests
{
    [TestClass]
    public class Navigations
    {
        private IWebDriver _driver;
        private BrowserHelper _browser;

        [TestInitialize]
        public void SetUpTest()
        {
            _browser = new BrowserHelper();
            _driver = _browser.LaunchBrowser();
        }

        [TestMethod]
        public void TestMethod1()
        {
            
        }

        [TestCleanup]
        public void TearDown()
        {
            _browser.CloseBrowser();

        }
    }
}
