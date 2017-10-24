﻿using System.Diagnostics;
using System.Threading;
using Com.ShoppingCart.Project.Pages;
using Com.ShoppingCart.Project.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Com.ShoppingCart.Project
{
    [TestClass]
    public class ECommerceShop
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

        [TestMethod, TestCategory("SIT")]
        public void CreateANewAccount()
        {
            var createAccount = new CreateAccount(_driver);
            createAccount.RegisterAccount();
        }

        [TestMethod]
        [TestCategory("Smoke")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"C:\Users\Andre\Desktop\userLoginDetails.csv",
            "userLoginDetails.csv",
            DataAccessMethod.Sequential)]
        public void LogUserIn()
        {
            var username = TestContext.DataRow["username"] as string;
            var password = TestContext.DataRow["password"] as string;

            var loginPage = new LoginPage(_driver);
            loginPage.LoginAsValidUser(username, password);

            var logoutButton = _driver.FindElement(By.ClassName("ico-logout"));
            Assert.IsTrue(logoutButton.Displayed);
        }

        [TestMethod]
        [TestCategory("Smoke")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"F:\cSharp2017\CSharpEssentials2017\ShoppingCart\Com.ShoppingCart.Project\DataFiles\invalidUserLoginDetails.csv",
            "invalidUserLoginDetails.csv",
            DataAccessMethod.Sequential)]
        public void InvalidUserLogin()
        {
            var usernameOrig = TestContext.DataRow["username"] as string;
            var passwordOrig = TestContext.DataRow["password"] as string;

            Debug.Assert(usernameOrig != null, "usernameOrig != null");
            var splitUserName = usernameOrig.Split('-');
            Debug.Assert(passwordOrig != null, "passwordOrig != null");
            var splitPassword = passwordOrig.Split('-');

            var username = splitUserName[1];
            var password = splitPassword[1];

            //select login tab from the landing page
            var loginTab = _driver.FindElement(By.ClassName("ico-login"));
            loginTab.Click();

            //enter email
            var loginEmail = _driver.FindElement(By.Id("Email"));
            //loginEmail.SendKeys("wale@hotmail.com");
            loginEmail.SendKeys(username);

            //enter password
            var loginPassword = _driver.FindElement(By.Id("Password"));
            //loginPassword.SendKeys("welcome123");
            loginPassword.SendKeys(password);

            //click login button
            var loginButton = _driver.FindElement(By.ClassName("login-button"));
            loginButton.Click();
            Thread.Sleep(4000);

            //var logoutButton = _driver.FindElement(By.ClassName("ico-logout"));

            //Assert.IsTrue(!logoutButton.Displayed);
        }

        [TestMethod]
        [TestCategory("SIT")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            //"|DataFiles|F\\cSharp2017\\CSharpEssentials2017\\ShoppingCart\\Com.ShoppingCart.Project\\DataFiles\\invalidUserLoginDetails.csv",
            @"F:\cSharp2017\CSharpEssentials2017\ShoppingCart\Com.ShoppingCart.Project\DataFiles\newInvalidUserLoginDetails.csv",
            "newInvalidUserLoginDetails#csv",
            DataAccessMethod.Sequential)]
        public void AnotherInvalidUserLogin()
        {
            var username = TestContext.DataRow["username"] as string;
            var password = TestContext.DataRow["password"] as string;

            //select login tab from the landing page
            var loginTab = _driver.FindElement(By.ClassName("ico-login"));
            loginTab.Click();

            // enter email
            if (username != null)
            {
                var loginEmail = _driver.FindElement(By.Id("Email"));
                loginEmail.SendKeys(username);
            }

            // enter password
            if (password != null)
            {
                var loginPassword = _driver.FindElement(By.Id("Password"));
                loginPassword.SendKeys(password);
            }

            // click login button
            var loginButton = _driver.FindElement(By.ClassName("login-button"));
            loginButton.Click();

            Thread.Sleep(4000);
        }

        [TestCleanup]
        public void TearDownTest()
        {
            _browser.CloseBrowser();
        }
    }
}