using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Com.ShoppingCartTask.Pages
{
    
    public class LoginPage
    {

        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void LoginAsValidUser(string username, string password)
        {
            //selectlogin tab from the landing page
            var loginTab = _driver.FindElement(By.ClassName("ico-login"));
            loginTab.Click();

            //enter email
            var loginEmail = _driver.FindElement(By.Id("Email"));
            //   loginEmail.SendKeys("kala@yahoo.com"); // after the datasheet is atatched we do not need this any more
            loginEmail.SendKeys(username);
            //enter password
            var loginPassword = _driver.FindElement(By.Id("Password"));
            //  loginPassword.SendKeys("welcome123"); // after the datasheet is atatched we do not need this any more
            loginPassword.SendKeys(password);

            //click login button
            var loginButton = _driver.FindElement(By.ClassName("login-button"));
            loginButton.Click();
            Thread.Sleep(4000);
        }

    }
}
