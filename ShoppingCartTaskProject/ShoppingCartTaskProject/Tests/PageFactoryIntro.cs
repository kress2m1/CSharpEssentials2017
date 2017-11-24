using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ShoppingCartTaskProject.Pages;
using ShoppingCartTaskProject.Utilities;

namespace ShoppingCartTaskProject.Tests
{
    [TestClass]
    public class PageFactoryIntro
    {
        private IWebDriver _driver;
        private BrowserHelper _browser;

       
        [TestInitialize]
        public void StartUpBrowser()
        {
            //this is outside testmethod so that other
            //methods can access it
            _browser = new BrowserHelper();
            _driver = _browser.LaunchBrowser();

        }

        [TestMethod]
        [TestCategory("Page Factory")]
        public void BasicNavigation()
        {
           //Driver.Navigate().Back();
           // Driver.Navigate().Forward();
           //Thread.Sleep(2000);
           // _driver.Navigate().Refresh();
           // _driver.Navigate().Back();
           // Thread.Sleep(2000);
           // _driver.Navigate().Forward();

            PFModel pfModel = new PFModel(_driver);
            pfModel.ClickRegisterButton();
            Thread.Sleep(2000);

        }

        [TestCleanup]
        public void TearDownTest()
        {
            _browser.CloseBrowser();
        }
    }
}
