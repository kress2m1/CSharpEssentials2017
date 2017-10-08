using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestTKMAXXProject1
{
    [TestClass]
    public class PageTest
    {
        private IWebDriver _driver;

        [TestInitialize]
        public void SetupTest()

        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://www.tkmaxx.com/uk/en/");
            
        }

        
        [TestMethod]
        public void GetPageTitle()
        {
            var PageTitle = _driver.Title;
            Assert.AreEqual(PageTitle, "Knitwear - Cardigans - Jumpers - Designer - TK Maxx - TK Maxx");
        }
        [TestMethod]

        public void TestMethod1()
        {

        }

        [TestCleanup]
        public void TearDown()
        {
            _driver.Quit();
        }

    }


}
