using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Com.Bags
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver _driver;

        [TestInitialize]
        public void SetUpTest()
        {
            //
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.capita.com/"); //"https://www.autodata-group.com/uk/");
        }

        [TestMethod]
        public void GetPageTitle() //CallTest() 
        {
            //Console.WriteLine("This is first test");
            string pageTitle = _driver.Title;
            Assert.AreEqual(pageTitle, "Technology-enabled outsourcing (BPO) & business process management (BPM) solutions UK | Capita");
            //"Autodata: vehicle technical data for service, maintenance, repair");
        }

        [TestMethod]
        public void MyTest()
        {
            Console.WriteLine("My Test 2");
        }

        [TestCleanup]
        public void TearDownTest()
        {
            _driver.Quit();
        }
    }
}
