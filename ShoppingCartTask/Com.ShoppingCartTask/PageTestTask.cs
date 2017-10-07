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

        [TestMethod, TestCategory("Smoke")]
        public void GetPageTitle()
        {
            //Console.WriteLine("This is a test to get the page title");
            //let us take away the consolewriteline
            var pageTitle = _driver.Title;
            Assert.AreEqual(pageTitle, "My Store", "The expected & actual don't match");
            //the above means run the code get the page title and compare it to
            //what i know it shd be "My Store"
        }

        [TestMethod, TestCategory("UAT")]
        public void CheckForCookies()
        {
            var allcookies = _driver.Manage().Cookies.AllCookies;
            foreach (var cookies in allcookies)//get me all cookies and i will check for it
            {
                Console.WriteLine("The List of cookies are {0}", cookies.ToString());
            }
        }

        [TestMethod]
        public void ConfirmUserOnHomePage()
        {
            var ContactUs = _driver.PageSource.ToLower().Contains("Contact us".ToLower());
            //go to the page source change it to lower, confirm it has contactus 
            //change it to lower
            Assert.IsTrue(ContactUs);

        }

        [TestCleanup]
        public void TearDownTest()
        {
            _driver.Quit(); // will close everything
           //_driver.Close(); //will only close the most recent one

        }
    }
}
