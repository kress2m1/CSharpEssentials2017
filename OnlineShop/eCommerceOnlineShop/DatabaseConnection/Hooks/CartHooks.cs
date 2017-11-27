using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceOnlineShop.BrowserFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace eCommerceOnlineShop.Hooks
{
    [TestClass]
    public class CartHooks
    {
        private IWebDriver _driver;
        private BrowserRepo _browserRepo;

        [TestInitialize]
        public void StartTest()
        {
            _browserRepo = new BrowserRepo();
            _driver = _browserRepo
                .InitializeBrowser()
                .SetupBrowser();
        }

        [TestCleanup]
        public void ShutDownTest()
        {
            _browserRepo.CloseBrowser();   
        }

    }
}
