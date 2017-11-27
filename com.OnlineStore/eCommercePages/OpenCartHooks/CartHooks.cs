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
        private IWebDriver _driver;

        [TestInitialize]
        public void StartUpBrowser()
        {
            _browserRepo = new BrowserRepo();
            _browserRepo.InitializeBrowser();
            _driver = _browserRepo.SetUpBrowser();
            var basepage = new Basepage(_driver);
            basepage.GoToHomePage();

            var pagetitle = "OpenCart - Open Sourcee Shopping Cart Solution";
            var titlePage = _driver.Title;
            Assert.AreEqual(pagetitle, titlePage, "The pagetile does not match title");
            Console.WriteLine(titlePage);
        }

        [TestCleanup]
        public void CloseDownBrowser()
        {
            _browserRepo.CloseBrowser();
        }
    }
}
