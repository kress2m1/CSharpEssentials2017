using System;
using System.Diagnostics;
using System.Threading;
using Com.ShoppingCart.Project.Pages;
using Com.ShoppingCart.Project.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Com.ShoppingCart.Project.Tests
{
    [TestClass]
    public class ECommerceShop
    {
        private IWebDriver _driver;
        private BrowserHelper _browser;

        //[FindsBy(How = How.ClassName, Using = "login")]
        //public IWebElement Login { get; set; }

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
        public void  ValidLogUserIn()
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

        [TestMethod]
        [DataSource("System.Data.OleDB",
            @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=F:\cSharp2017\CSharpEssentials2017\ShoppingCart\Com.ShoppingCart.Project\DataFiles\AvailableNotebooks.xlsx;
            Extended Properties='Excel 12.0;HDR=yes';",
            "Sheet1$", DataAccessMethod.Sequential)]
        public void NarrowSearchForNotebook()
        {
            var CPUType = (string) TestContext.DataRow["CPUType"];
            var Memory = (string) TestContext.DataRow["Memory"];
            var Notebook = (string) TestContext.DataRow["MachineName"];
            var Price = (string) TestContext.DataRow["ItemAmount"];

            var computerPage = new ComputerPage(_driver);
            computerPage.SearchForPcAndAssert();

            Assert.IsTrue(computerPage.ValidateResult(CPUType));
            Assert.IsTrue(computerPage.ValidateResult(Memory));
            Assert.IsTrue(computerPage.ValidateResult(Notebook));
            Assert.IsTrue(computerPage.ValidateResult(Price));
        }

        [TestCleanup]
        public void TearDownTest()
        {
            _browser.CloseBrowser();
        }
    }
}