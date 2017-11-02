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
    public class LoginPage : BasePage
    {
     
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public ComputerPage LoginAsValidUser(string username, string password)
        {
            //select login tab from the landing page
            var loginTab = Driver.FindElement(By.ClassName("ico-login"));
            loginTab.Click();

            //enter email
            var loginEmail = Driver.FindElement(By.Id("Email"));
            //loginEmail.SendKeys("wale@hotmail.com");
            loginEmail.SendKeys(username);

            //enter password
            var loginPassword = Driver.FindElement(By.Id("Password"));
            //loginPassword.SendKeys("welcome123");
            loginPassword.SendKeys(password);

            //click login button
            var loginButton = Driver.FindElement(By.ClassName("login-button"));
            loginButton.Click();
            Thread.Sleep(4000);
            //return new LogOutPage(Driver); 
            //return new ComputerPage(Driver);
            return new ComputerPage(Driver);

        }  
    }
}
