using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewOnlineShop.BrowserFactory;
using OpenQA.Selenium;

namespace NewOnlineShop.Hooks
{
    [TestClass]
    public class OpenCartHooks
    {
        private BrowserRepo _browserRepo;
        private IWebDriver _driver;

        [TestInitialize]
        public void StartUpBrowser()

        {
            _browserRepo = new BrowserRepo();
            _browserRepo.InitializeBrowser();
          //      .SetUpBrowser();
            _driver = _browserRepo.SetUpBrowser();
        }

        [TestCleanup]
        public void CloseDownBrowser()
        {
            //BrowserRepo browserRepo = new BrowserRepo();//removed as a result
            //of above modification
            _browserRepo.CloseBrowser();

        }
    }
}
