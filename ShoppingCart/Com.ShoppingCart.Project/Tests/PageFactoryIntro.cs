using System;
using System.Threading;
using Com.ShoppingCart.Project.Pages;
using Com.ShoppingCart.Project.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Com.ShoppingCart.Project.Tests
{
    [TestClass]
    public class PageFactoryIntro 
    {
        private IWebDriver _driver;
        private BrowserHelper _browser;


        [TestInitialize]
        public void StartUpBrowser()
        {
            _browser = new BrowserHelper();
            _driver = _browser.LaunchBrowser();
        }

        [TestMethod]
        [TestCategory("Page Factory")]
        public void BasicNavigation()
        {
            var pfModel = new PFModel(_driver);
            pfModel.ClickRegisterButton();
        }

        [TestCleanup]
        public void TearDownTest()
        {
            _browser.CloseBrowser();
        }
    }
}
