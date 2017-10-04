using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Com.ShoppingCartTask
{
    [TestClass]
    public class PageTestTask
    {
        private IWebDriver _driver; //we declare it outside the test method because 
                                    //we wnat to runn it somewhere else
        [TestInitialize]
        public void SetUpTest()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [TestMethod]
        public void GetPageTitle()
        {
            Console.WriteLine("This is a test to get the page title");
            var pageTitle = _driver.Title;
            Assert.AreEqual(pageTitle, "My Store");
        }

        [TestMethod]
        public void CallAnotherTest()
        {
            Console.WriteLine("This is another test");
        }

        [TestCleanup]
        public void TearDownTest()
        {
            _driver.Quit();
        }
    }
}
