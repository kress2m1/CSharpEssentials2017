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
        public TestContext TestContext { get; set; }

        [TestMethod, TestCategory("SMOKE")]
        [DataSource("System.Data.OleDB",
            @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=F:\cSharp2017\CSharpEssentials2017\com.OnlineStore\eCommerceTest\DataFiles\OpenCartDataSource.xlsx;
            Extended Properties='Excel 12.0;HDR=yes';",
            "titleCheck$", DataAccessMethod.Sequential)]
        public void CheckHomePageTitle()
        {
            var pagetitle = TestContext.DataRow["OpenCartPageTitle"];
            var titlePage = _driver.Title;
            Assert.AreEqual(pagetitle, titlePage, "The page title does not match title");
            Thread.Sleep(3000);
        }
    }
}
