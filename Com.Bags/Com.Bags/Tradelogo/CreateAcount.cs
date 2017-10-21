using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Com.Bags
{
    [TestClass]
    public class CreateAcount
    {
        private IWebDriver _driver;

        [TestInitialize]
        public void SetUpTest()
        {
           // _driver = new FirefoxDriver();
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            // _driver.Navigate().GoToUrl("http://www.capita.com/"); //"https://www.autodata-group.com/uk/");

            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
             //_driver.Navigate().GoToUrl("http://demo.nopcommerce.com/");
        }

        [TestMethod, TestCategory("UAT")]
        public void GetPageTitle() //CallTest() 
        {
            //Console.WriteLine("This is first test");
            var pageTitle = _driver.Title;

            Assert.AreEqual(pageTitle, "My Store");//Technology-enabled outsourcing (BPO) & business process management (BPM) solutions UK | Capita");
            //"Autodata: vehicle technical data for service, maintenance, repair");
        }

        [TestMethod, TestCategory("Smoke")]
        public void CreateAccount()
        {
            //Console.WriteLine("My Test 2");

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            _driver.FindElement(By.ClassName("login")).Click();
            var signInPagetitle = _driver.Title;
            Assert.AreEqual(signInPagetitle.ToLower(), "Login - My Store".ToLower());

            var email = _driver.FindElement(By.Id("email_create"));
            email.SendKeys("moj@sel.com");


            var submitButton = _driver.FindElement(By.Id("SubmitCreate"));
            submitButton.Click();

            // select radio button
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("id_gender2")));
            var selectMrs = _driver.FindElement((By.Id("id_gender2")));
            selectMrs.Click();
            var firstName = _driver.FindElement((By.Id("customer_firstname")));
            firstName.SendKeys("Tobi");

            var dayOfBirth = _driver.FindElement(By.Id("days"));
            var selectDayOfBirth = new SelectElement(dayOfBirth);
            selectDayOfBirth.SelectByValue("3");

            var monthOfBirth = _driver.FindElement(By.Id("months"));
            var selectMonthOfBirth = new SelectElement(monthOfBirth);
            selectMonthOfBirth.SelectByIndex(6);

            var yearOfBirth = _driver.FindElement(By.Id("years"));
            var selectYrOfBirth = new SelectElement(yearOfBirth);
            selectYrOfBirth.SelectByValue("2014");
        }

        [TestMethod] //ignore
        public void Checkcookies()
        {
            var allcookies = _driver.Manage().Cookies.AllCookies;
            foreach (var cookie in allcookies)
            {
                Console.WriteLine("The list of cookies are {0}", cookie.ToString());
            }
        }

        [TestMethod]
        public void ConfirmUserOnHomePage()
        {
            //  var contactUs = _driver.PageSource.ToLower().Contains("Contact us".ToLower());

            //  Assert.IsTrue(contactUs);
            var aboutUs = _driver.PageSource.ToLower().Contains("About us".ToLower());
            Assert.IsTrue(aboutUs);
        }

        [TestCleanup]
        public void TearDownTest()
        {
            Thread.Sleep(10000);
            _driver.Close();
            _driver.Quit();
        }
    }
}
