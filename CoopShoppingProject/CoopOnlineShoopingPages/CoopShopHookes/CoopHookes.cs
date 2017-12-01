using CoopShoppingCom.BrowserFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace CoopShoppingCom.CoopShopHookes
{
    [TestClass]
   public class CoopHookes
    {
        private BrowserShop _browserShop;
        private IWebDriver _driver;

        [TestInitialize]
        public void StartUpBrowser()
{
        _browserShop = new BrowserShop();
            _browserShop.InitializeBrowser();
            _driver = _browserShop.SetUpBrowser();
           
        }
    [TestCleanup]
    public void CloseDownBrowser()
    {
        _browserShop.CloseBrowser();
    }

    
    }
}
