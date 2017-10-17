using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Com.ShoppingCart.Project
{
    [TestClass]
    public class LoginUser
    {
        private IWebDriver _driver;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void SetUpTest()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://demo.nopcommerce.com/");
        }

        [TestMethod, TestCategory("Smoke")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"C:\Users\Andre\Desktop\userLoginDetails.csv",
            "userLoginDetails.csv",
            DataAccessMethod.Sequential)]
        public void LogUserIn()
        {
            var username = TestContext.DataRow[0] as string;
            var password = TestContext.DataRow[1] as string;

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

            var logoutButton = _driver.FindElement(By.ClassName("ico-logout"));

            Assert.IsTrue(logoutButton.Displayed);
        }

        [TestCleanup]
        public void TearDownTest()
        {
            _driver.Quit();
        }
    }
}
