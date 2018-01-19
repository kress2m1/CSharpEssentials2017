using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using eCommerce.OpenCartHooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace eCommerceTest.OpenCartTest
{
    [TestClass]
    public class SearchForItems : CartHooks
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("SMOKE")]
        [DataSource("System.Data.OleDB",
            @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=F:\cSharp2017\CSharpEssentials2017\com.OnlineStore\eCommerceTest\DataFiles\OpenCartDataSource.xlsx;
            Extended Properties='Excel 12.0;HDR=yes';",
            "itemSearch$", DataAccessMethod.Sequential)]
        public void LocateItem()
        {
            var cameraMenu = _driver.FindElement(By.LinkText("Cameras"));
            cameraMenu.Click();

            var searchButton = _driver.FindElement(By.Name("search"));
            searchButton.SendKeys("Canon");

            var searchConfirm = _driver.FindElement(By.ClassName("btn-default"));
            searchConfirm.Click();
            Thread.Sleep(2000);
        }

    }
}
