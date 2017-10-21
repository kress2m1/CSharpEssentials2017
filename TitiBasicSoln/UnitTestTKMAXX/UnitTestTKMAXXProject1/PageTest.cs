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
            _driver.Navigate().GoToUrl("https://www.aldi.co.uk//");
            
        }

        
        [TestMethod]
        public void GetPageTitle()
        {
            var PageTitle = _driver.Title;
            Assert.AreEqual(PageTitle, "ALDI UK | Homepage");
        }
        [TestMethod]

        public void ProductSearch()
        {
            var Search = _driver.FindElements(By.XPath("button button--interaction button--round js-typeahead-open".));
            



        }

        [TestCleanup]
        public void TearDown()
        {
            _driver.Quit();
        }

    }


}
