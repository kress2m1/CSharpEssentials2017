using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CoopShoppingCom.Configuration;
using CoopShoppingCom.CoopShopHookes;
using OpenQA.Selenium;

namespace CoopOnlineShoppingTest.Test
{
        [TestClass]
        public class CoopShopHomePageValidationTest : CoopHookes
        {
            [TestMethod]
            public void CheckCoopHomePageTitle()

            {
                Console.WriteLine(CoopShoppingConfig.Default.Browser);
                Console.WriteLine("This is MSTest");
                Thread.Sleep(3000);
            }



            [TestInitialize]
        public void InitializeBrowser()
        {

        }


    }

}


 
    

