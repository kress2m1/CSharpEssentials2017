using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Com.Bags
{
    [TestClass]
    public class InvalidLogin
    {
        public object TestMethod { get; set; }

        IWebDriver _driver;
        private object usernameOrig;
        private bool passwordOrig;
    

    
        
        [TestMethod,TestCategory("UAT")]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory |\\data.csv", "data#csv",
        //  @"C:\Users\Rachel\Documents\CsharpRepo\CSharpEssentials2017\Com.Bags\Com.Bags\Tradelogo\InvalidLogin.csv,
        //    "InvalidLogin.csv", DataAccessMethod.Sequential)]
        public void InvalidUserLogin()
        {
       
            var username = TestContext.DataRow["username"] as string;
            var password = TestContext.DataRow["password"] as string;


            Debug.Assert(usernameOrig != null, "usernameOrig ! = null");
            var splitUserName = usernameOrig.Split("-");
            Debug.Assert(passwordOrig ! = null, "passwordOrig ! = null");
            var splitPassword = passwordOrig.Split("-");

            username = splitUserName[1];
            password = splitPassword[1];
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
        public void tearDownLoginPage()
        {
            //_driver.Close();
            _driver.Quit();
        }

        

        private void DataSource(string microsoftVisualstudioTesttoolsDatasourceCsv, string datadirectoryDataCsv, string dataCsv, object C)
        {
            throw new NotImplementedException();
        }

        
    }
}
