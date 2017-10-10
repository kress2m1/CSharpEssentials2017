using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Com.ShoppingCart.Project
{
    [TestClass]
    public class PageTest
    {
        private IWebDriver _driver;

        [TestInitialize]
        public void SetUpTest()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [TestMethod, TestCategory("Smoke")]
        public void GetPageTitle()
        {
            var pageTitle = _driver.Title;
            Assert.AreEqual(pageTitle, "My Store", "The expected & actual don't match");
        }

        [TestMethod, TestCategory("UAT")]
        public void CheckForCookies()
        {
            var allCookies = _driver.Manage().Cookies.AllCookies;
            foreach (var cookie in allCookies)
            {
                Console.WriteLine("The list of cookies are {0}", cookie.ToString());
            }
        }

        [TestMethod]
        public void ConfirmUserOnHomePage()
        {
            var contactUs = _driver.PageSource.ToLower().Contains("header_logo".ToLower());
            Assert.IsTrue(contactUs);
        }

        [TestCleanup]
        public void TearDownTest()
        {
            _driver.Quit();
            //_driver.Close();
        }
    }
}
