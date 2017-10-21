using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Com._1stSeleniumTrial
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver _driver;

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
            Console.WriteLine("This is a test to get page title");
           var pagetitle = _driver.Title;
            Assert.AreEqual(pagetitle, "My Store");
        }

        [TestMethod]
        public void CallOneOtherTest()
        {
            Console.WriteLine("One other Test");
        }

        [TestCleanup]
        public void TearDownTest()
        {
            _driver.Quit();
        }
    }
}
