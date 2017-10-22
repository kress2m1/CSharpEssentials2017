using System;
using System.Runtime.Remoting.Channels;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Com.Bags
{
    [TestClass]
    public class ValidLogin
    {
        private IWebDriver _driver;

        public  TestContext TestContext { get; set; }

        [TestInitialize]
        public void SetUpTest()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://demo.nopcommerce.com/");
        }

        [TestMethod, TestCategory("Smoke")]
      //  [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",@"","userLoginDetails.csv",DataAccessMethod.Sequential)]
        public void UserLogIn()
        {
            var loginTab = _driver.FindElement(By.ClassName("ico-login"));
            loginTab.Click();

            var loginEmail = _driver.FindElement(By.Id("Email"));
            loginEmail.SendKeys("tinu@gmail.com");

            var loginPassword = _driver.FindElement(By.Id("Password"));
            loginPassword.SendKeys("pass123");


            var loginButton = _driver.FindElement(By.ClassName("login-button"));
            loginButton.Click();

            var logoutButton = _driver.FindElement(By.ClassName("ico-logout"));
            Assert.IsTrue(logoutButton.Displayed);




        }
        [TestCleanup]
        public void TearDown()
        
        {
           // Thread.Sleep(30000);
            _driver.Close();
        }



    }
}
