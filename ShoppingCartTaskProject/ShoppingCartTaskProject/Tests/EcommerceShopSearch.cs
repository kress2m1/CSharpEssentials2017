﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using ShoppingCartTaskProject.Utilities;

namespace ShoppingCartTaskProject.Tests
{
    [TestClass]
    public class EcommerceShopSearch
    {
        private IWebDriver _driver;
        private BrowserHelper _browser;

        public TestContext TestContext { get; set; }

        //[TestInitialize]
        
        //{
        //    _browser = new BrowserHelper();
        //    _driver = _browser.LaunchBrowser();

        //}

        [TestMethod]
        [TestCategory("Smoke")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"C:\Users\omo akin\Documents\Automation2017\CSharpEssentials2017\ShoppingCartTaskProject\ShoppingCartTaskProject\DataFiles\userLoginDetails.csv",
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
