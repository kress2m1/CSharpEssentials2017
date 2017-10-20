using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Redo.com
{
    [TestClass]
    public class TradingBag
    {
        IWebDriver _driver;
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void Launchbrowser()
        {
            _driver=new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://demo.nopcommerce.com/");
        }


        [TestMethod,TestCategory("SMOKE")]
        public void Getpagetitle()
        {
            
            var pageTitle = _driver.Title;
            Assert.AreEqual(pageTitle, "nopCommerce demo store", "The expected & actual do not match ");
        }

        [TestMethod, TestCategory("SIT")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory |\\data.csv", "data#csv",
         DataAccessMethod.Sequential)]
        public void validUserLogin()
        {
            string username = TestContext.DataRow["username"] as string;
            string password = TestContext.DataRow["password"] as string;
            
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
            System.Threading.Thread.Sleep(4000);
        }

        [TestMethod, TestCategory("UAT")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory |\\data.csv", "data#csv",
            DataAccessMethod.Sequential)]
        public void InvalidUserLogin()
        {
            string username = TestContext.DataRow["username"] as string;
            string password = TestContext.DataRow["password"] as string;
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
            System.Threading.Thread.Sleep(4000);
            var logoutButton = _driver.FindElement(By.ClassName("ico-logout"));
            Assert.IsTrue(!logoutButton.Displayed);
        }

        [TestCleanup]
         public void ValidLogin()
        {

        }


       
    }

}
