using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TradingKeys
{
    [TestClass]
    public class UnitTestTrade1
    {

        IWebDriver _driver;



        [TestInitialize]

        public void SetUpBrowser()
        {

            
             _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://demo.nopcommerce.com/");
        }

        [TestMethod, TestCategory("Smoke")]
        public void GetPageTitle()
        {
            var pageTitle = _driver.Title;
            Assert.AreEqual(pageTitle, "nopCommerce demo store");
        }

        [TestMethod]
        public void Register()
        {
            var registerbutton = _driver.FindElement(By.ClassName("ico-register"));
            registerbutton.Click();

            var registerPage = _driver.Title;
            Assert.AreEqual(registerPage, "nopCommerce demo store. Register");

            var femaleGender = _driver.FindElement(By.Id("gender-female"));
            femaleGender.Click();

            var firstName = _driver.FindElement(By.Id("FirstName"));
            firstName.SendKeys("Tinu");

            var lastName = _driver.FindElement(By.Id("LastName"));
            lastName.SendKeys("Tais");

            var dayOfBirth = _driver.FindElement(By.Name("DateOfBirthDay"));
            var selectDayOfBirth = new SelectElement(dayOfBirth);
            selectDayOfBirth.SelectByIndex(8);


            var monthOfBirth = _driver.FindElement(By.Name("DateOfBirthMonth"));
            var selectMonthOfBirth = new SelectElement(monthOfBirth);
            selectMonthOfBirth.SelectByValue("8");

            var yearOfBirth = _driver.FindElement(By.Name("DateOfBirthYear"));
            var selectyearOfBirth = new SelectElement(yearOfBirth);
            selectyearOfBirth.SelectByText("2000");

            var email = _driver.FindElement(By.Id("Email"));

            var newsletterBox = _driver.FindElement(By.Id("Email"));

            if (!newsletterBox.Selected)
            {
                newsletterBox.Click();
            }
        }



        [TestCleanup]
        public void TearDown()
  
        {
            Thread.Sleep(3000);
            _driver.Close();
        }


    }
    }

