using System;
using eCommerce.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eCommerceTest.OpenCartTest
{
    [TestClass]
    public class OpenCartHomepageValidationTest
    {
        [TestMethod]
        public void CheckHomePageTitle()
        {
            Console.WriteLine(OpenCartFramework.Default.Browser);
            Console.WriteLine("This is MSTest");
        }
    }
}
