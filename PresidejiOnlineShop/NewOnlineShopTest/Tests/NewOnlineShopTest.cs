using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewOnlineShop.Configuration;
using NewOnlineShop.Hooks;
using OpenQA.Selenium;

namespace NewOnlineShopTest.Tests
{
    [TestClass]
    public class NewOnlineShopTest : OpenCartHooks
    {
        
        [TestMethod]
        public void CheckHomePageTitle()
        {
            Console.WriteLine(NewOnlineShopConfig.Default.Browser);
            Console.WriteLine("This is MSTest");
            Thread.Sleep(3000);
        }

        
    }
}
