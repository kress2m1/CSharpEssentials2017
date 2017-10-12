using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Com.ShoppingCart.Project
{
    [TestClass]
    public class PageTest
    {
        private IWebDriver _driver;

        [TestInitialize]
        public void SetUpTest()
        {
            _driver = new FirefoxDriver();
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

        [TestMethod, TestCategory("Smoke")]
        public void RegisterAccount()
        {
            //declare wait method
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

            _driver.FindElement(By.ClassName("login")).Click();
            var signInPagetitle = _driver.Title;
            Assert.AreEqual(signInPagetitle.ToLower(), "Login - My Store".ToLower());

            //select email field and send email address
            var email = _driver.FindElement(By.Id("email_create"));
            email.SendKeys("wale@hotmail.com");

            //find submit button and click it
            var submitButton = _driver.FindElement(By.Id("SubmitCreate"));
            submitButton.Click();

            //select the radio button for Mr
            //wait.Until(ExpectedConditions.ElementIsVisible(By.Id("id_gender1")));
            //var selectMr = _driver.FindElement(By.Id("id_gender1"));
            //selectMr.Click();

            ////enter firstname
            //var firstName = _driver.FindElement(By.Id("customer_firstname"));
            //firstName.SendKeys("Andre");

            //select day of birth
            //wait.Until(ExpectedConditions.ElementIsVisible(By.Id("days")));
            //var dayOfBirth = _driver.FindElement(By.Id("days"));
            //var selectDayOfBirth = new SelectElement(dayOfBirth);
            //selectDayOfBirth.SelectByValue("2");

            ////select month of birth
            //wait.Until(ExpectedConditions.ElementIsVisible(By.Id("months")));
            //var monthOfBirth = _driver.FindElement(By.Id("months"));
            //var selectMonthOfBirth = new SelectElement(monthOfBirth);
            //selectMonthOfBirth.SelectByIndex(4);

            ////select year of birth
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("years")));
            var yearOfBirth = _driver.FindElement(By.Id("years"));
            var selectYearOfBirth = new SelectElement(yearOfBirth);
            selectYearOfBirth.SelectByValue("2");

            //select checkbox
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("newsletter")));
            var newsletterSignUp = _driver.FindElement(By.Id("newsletter"));
            newsletterSignUp.Click();
        }

        [TestMethod, TestCategory("UAT")]
        public void ConfirmUserOnHomePage()
        {
            var contactUs = _driver.PageSource.ToLower().Contains("header_logo".ToLower());
            Assert.IsTrue(contactUs);
        }

        [TestCleanup]
        public void TearDownTest()
        {
            Thread.Sleep(10000);
            _driver.Quit();
            //_driver.Close();
        }
    }
}
