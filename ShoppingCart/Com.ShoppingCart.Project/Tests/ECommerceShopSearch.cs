using System;
using Com.ShoppingCart.Project.Pages;
using Com.ShoppingCart.Project.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Com.ShoppingCart.Project.Tests
{
    [TestClass]
    public class ECommerceShopSearch
    {

        private IWebDriver _driver;
        private BrowserHelper _browser;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void SetUpTest()
        {
            _browser = new BrowserHelper();
            _driver = _browser.LaunchBrowser();
        }

        [TestMethod]
        [TestCategory("Smoke")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"C:\Users\Andre\Desktop\userLoginDetails.csv",
            "userLoginDetails.csv",
            DataAccessMethod.Sequential)]
        public void ValidLogUserIn()
        {
            var username = TestContext.DataRow["username"] as string;
            var password = TestContext.DataRow["password"] as string;

            var createAccount1 = new CreateAccount(_driver);
            createAccount1
                .RegisterAccount()
                .LoginAsValidUser(username, password)
                .SearchForPc()
                .LogUserOut();
        }

        [TestCleanup]
        public void TearDownTest()
        {
            _browser.CloseBrowser();
        }

    }
}
