using System;
using System.Threading;
using eCommerce.Configuration;
using eCommerce.OpenCartHooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eCommerceTest.OpenCartTest
{
    [TestClass]
    public class OpenCartHomepageValidationTest : CartHooks
    {

        [TestMethod]
        public void CheckHomePageTitle()
        {
            Console.WriteLine(OpenCartFramework.Default.Browser);
            Console.WriteLine("This is MSTest");
            Thread.Sleep(3000);
        }
    }
}
