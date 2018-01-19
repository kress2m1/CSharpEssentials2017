using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using eCommerce.OpenCartHooks;
using eCommercePages.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace eCommerceTest.OpenCartTest
{
    [TestClass]
    public class ValidateHeadersMenuTest : CartHooks
    {
        public TestContext TestContext { get; set; }

        [TestMethod, TestCategory("SMOKE")]
        [DataSource("System.Data.OleDB",
            @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=F:\cSharp2017\CSharpEssentials2017\com.OnlineStore\eCommerceTest\DataFiles\OpenCartDataSource.xlsx;
            Extended Properties='Excel 12.0;HDR=yes';",
            "headers$", DataAccessMethod.Sequential)]

        public void CheckHeaderMenu()
        {
            var desktop = (string) TestContext.DataRow["DesktopTab"];
            var laptopsAndNotebooks = (string)TestContext.DataRow["LaptopsAndNotebooksTab"];
            var components = (string) TestContext.DataRow["ComponentsTab"];
            var tablets = (string) TestContext.DataRow["TabletsTab"];

            Basepage basepage = new Basepage(_driver);
            Homepage homepage = basepage.GoToHomePage();

            var validateTab = homepage.ValidateHeaderTabs(desktop);
            var comp = homepage.ValidateHeaderTabs(components);
            var tabletsComp = homepage.ValidateHeaderTabs(tablets);
            //var mobileDevices = homepage.ValidateHeaderTabs(laptopsAndNotebooks);
            
            Assert.IsTrue(validateTab);
            Assert.IsTrue(comp);
            Assert.IsTrue(tabletsComp);
            //Assert.IsTrue(mobileDevices);
        }
    }
}
