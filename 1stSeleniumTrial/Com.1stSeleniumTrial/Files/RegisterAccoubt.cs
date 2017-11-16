using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Com._1stSeleniumTrial.Files
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
        public void RegisterAccount()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            _driver.FindElement(By.ClassName("login")).Click();
            var signInPagetitle = _driver.Title;
            Assert.AreEqual(signInPagetitle.ToLower(), "Login - My Store".ToLower());

            var email = _driver.FindElement(By.Id("email_create"));
            email.SendKeys("anitaudokang@gmail.com");
            var password = _driver.FindElement(By.Id("passwd"));
           password.SendKeys("Abc1234");

            var submitButton = _driver.FindElement(By.Id("SubmitCreate"));
            submitButton.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("id_gender2")));
            var selectMrs = _driver.FindElement(By.Id("id_gender2"));
            selectMrs.Click();

            var firstName = _driver.FindElement(By.Id("customer_firstname"));
            firstName.SendKeys("Ani");

            var lastName = _driver.FindElement(By.Id("customer_lastname"));
            lastName.SendKeys("Ndi");

            var dayOfBirth = _driver.FindElement(By.Id("days"));
            var selectDayOfBirth = new SelectElement(dayOfBirth);
            selectDayOfBirth.SelectByValue("8");

            var monthOfBirth = _driver.FindElement(By.Id("months"));
            var selectMonthOfBirth = new SelectElement(monthOfBirth);
            selectMonthOfBirth.SelectByIndex(4);

            var yearOfBirth = _driver.FindElement(By.Id("years"));
            var selectYearOfBirth = new SelectElement(yearOfBirth);
            selectYearOfBirth.SelectByIndex(5);





        }
        


        [TestMethod, TestCategory("Smoke")]
        public void GetPageTitle()
        {
            
           var pagetitle = _driver.Title;
            Assert.AreEqual(pagetitle, "My Store");
        //}

        //[TestMethod, TestCategory("UAT"), Ignore]
        //public void CheckForCookies()
        //{
        
        //    var allCookies = _driver.Manage().Cookies.AllCookies;
        //    foreach (var cookie in allCookies)
        //    {
        //        Console.WriteLine("List of cookies are {0}",cookie.ToString());
        //    }
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
            Thread.Sleep(4000);
            _driver.Quit();
        }
    }
}
