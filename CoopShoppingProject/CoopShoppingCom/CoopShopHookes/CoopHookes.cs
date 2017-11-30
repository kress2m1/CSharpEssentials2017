using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoopShoppingCom.BrowserFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoopShoppingCom.CoopShopHookes
{
    [TestClass]
   public class CoopHookes
    {
        private BrowserShop _browserShop;
         
        [TestInitialize]
        public void StartUpBrowser()
{
        _browserShop = new BrowserShop();
        _browserShop.InitializeBrowser().SetUpBrowser();


}
    [TestCleanup]
    public void CloseDownBrowser()
    {
        _browserShop.CloseBrowser();
    }

    
    }
}
