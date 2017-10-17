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
        [TestMethod, TestCategory("Smoke")]
        public void GetPageTitle()
        {
            Console.WriteLine("This is a test to get page title");
           var pagetitle = _driver.Title;
            Assert.AreEqual(pagetitle, "My Store");
        }

        [TestMethod, TestCategory("UAT"), Ignore]
        public void CheckForCookies()
        {
        
            var AllCookies = _driver.Manage().Cookies.AllCookies;
            foreach (var cookie in AllCookies)
            {
                Console.WriteLine("List of cookies are {0}",cookie.ToString());
            }
        }

        [TestMethod]
        public void ConfirmUserOnHomePage()
        {
          var contactUs =  _driver.PageSource.ToLower().Contains("Contact Us".ToLower());
            Assert.IsTrue(contactUs);
        }


        [TestCleanup]
        public void TearDownTest()
        {
            _driver.Quit();
        }
    }
}
