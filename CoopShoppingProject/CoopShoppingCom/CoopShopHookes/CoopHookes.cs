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
        private BrowserShop _browsershop ;

        [TestInitialize]
        public void StartUpBrowser()
        {
             _browsershop = new BrowserShop();
             _browsershop.InitializeBrowser().SetUpBrowser();

        }

        [TestCleanup]
        public void CloseDownBrowser()
        {
            _browsershop.CloseBrowser();
        }
    }
}
