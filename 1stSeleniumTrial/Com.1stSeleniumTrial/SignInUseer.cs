using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Com._1stSeleniumTrial
{
    [TestClass]
    public class SignInUseer
    {
            private IWebDriver _driver;

            [TestInitialize]
            public void SetUpTest()
            {
                _driver = new ChromeDriver();
                _driver.Manage().Window.Maximize();
                _driver.Navigate().GoToUrl("https://www.clear.bank/");

            }

            [TestMethod, TestCategory("Smoke")]
            public void SignIn()
            {
                var signIn = _driver.FindElement(By.ClassName("login"));
            signIn.Click();

                var signInemail = _driver.FindElement(By.Id("email"));
            signInemail.SendKeys("anitaudokang@gmail.com");

                var signInPassword = _driver.FindElement(By.Id("passwd"));
            signInPassword.SendKeys("Abc123");

                var sigInButton = _driver.FindElement(By.Id("SubmitLogin"));
            sigInButton.Click();
            }

            [TestCleanup]
            public void TearDownTest()
            {
                _driver.Quit();
            }

        }
    }
    
