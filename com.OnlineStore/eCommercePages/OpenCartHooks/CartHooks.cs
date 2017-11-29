using System;
using eCommerce.BrowserFactory;
using eCommercePages.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace eCommerce.OpenCartHooks
{
    [TestClass]
    public class CartHooks
    {
        private BrowserRepo _browserRepo;
        protected IWebDriver _driver;

        [TestInitialize]
        public void StartUpBrowser()
        {
            _browserRepo = new BrowserRepo();
            _browserRepo.InitializeBrowser();
            _driver = _browserRepo.SetUpBrowser();
            var basepage = new Basepage(_driver);
            basepage.GoToHomePage();
        }

        [TestCleanup]
        public void CloseDownBrowser()
        {
            _browserRepo.CloseBrowser();
        }
    }
}
