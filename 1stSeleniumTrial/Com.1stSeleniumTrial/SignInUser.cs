using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Com._1stSeleniumTrial
{
    [TestClass]
    public class LogInUser
    {
            private IWebDriver _driver;

        public LogInUser(IWebDriver driver)
        {
            _driver = driver;
        }

        [TestInitialize]
            public void SetUpTest()
            {
                _driver = new ChromeDriver();
                _driver.Manage().Window.Maximize();
                _driver.Navigate().GoToUrl("http://demo.nopcommerce.com/");

            }

            [TestMethod, TestCategory("Smoke")]
            public void SignInUser()

        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
          

            var logInTab = _driver.FindElement(By.ClassName("ico-login"));
            logInTab.Click();

                var logInemail = _driver.FindElement(By.Id("Email"));
            logInemail . SendKeys("anitaudokang@gmail.com");

                var logInPassword = _driver.FindElement(By.Id("Password"));
            logInPassword.SendKeys("Abc1234");

                var logInButton = _driver.FindElement(By.ClassName("login-button"));
            logInButton.Click();

                var logOutBtn = _driver.FindElement(By.ClassName("ico-logout"));
         
            Assert.IsTrue(logOutBtn.Displayed);
            }

            [TestCleanup]
            public void TearDownTest()
            {
            Thread.Sleep(4000);
            //_driver.Quit();
        } 

        }
    }
    
