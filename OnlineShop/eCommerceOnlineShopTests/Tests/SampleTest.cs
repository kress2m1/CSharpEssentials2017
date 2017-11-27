using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceOnlineShop.Hooks;
using OpenQA.Selenium;

namespace eCommerceOnlineShopTests.Tests
{
    [TestClass]
    public class SampleTest : CartHooks
    {

        [TestInitialize]
        public void InitializeBrowser()
        {
            
        }

        [TestMethod]
        public void CheckHomePageTitle()
        {
            Console.WriteLine("Print Homepage Title");
        }
        
        
    }
}
