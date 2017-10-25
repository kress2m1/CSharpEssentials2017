using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Com.ShoppingCart.Project.Pages
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
        }
    }
}
