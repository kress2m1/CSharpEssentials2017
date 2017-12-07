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
            _driver.Navigate().GoToUrl("http://demo.nopcommerce.com/");
        }

        [TestMethod, TestCategory("Smoke")]
        public void RegisterAccount()
        {
            //var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            //_driver.FindElement(By.ClassName("login")).Click();

            var registerBtn = _driver.FindElement(By.ClassName("ico-register"));
            registerBtn.Click();

            var registerpage = _driver.Title;
            Assert.AreEqual(registerpage, "nopCommerce demo store. Register");

            var famaleGender = _driver.FindElement(By.Id("gender-female"));
            famaleGender.Click();

            var firstName = _driver.FindElement(By.Id("FirstName"));
            firstName.SendKeys("Chichi");

            var lastName = _driver.FindElement(By.Id("LastName"));
            lastName.SendKeys("Ndi");

            var dateOfBirth = _driver.FindElement(By.Name("DateOfBirthDay"));
            var selectDayOfBirth = new SelectElement(dateOfBirth);
            selectDayOfBirth.SelectByIndex(8);

            var monthOfBirth = _driver.FindElement(By.Name("DateOfBirthMonth"));
            var selectMonthOfBirth = new SelectElement(monthOfBirth);
            selectMonthOfBirth.SelectByIndex(4);


            var yearOfBirth = _driver.FindElement(By.Name("DateOfBirthYear"));
            var selectYearOfBirth = new SelectElement(yearOfBirth);
            selectYearOfBirth.SelectByText("1990");

            var email = _driver.FindElement(By.Id("Email"));
            email.SendKeys("anitaudokang@gmail.com");

            var password = _driver.FindElement(By.Id("Password"));
            password.SendKeys("Abc1234");

            var newsLetterBox = _driver.FindElement(By.Id("Newsletter"));
            if (!newsLetterBox.Selected)
            {
                newsLetterBox.Click();
            }

            var passwordConfirm = _driver.FindElement(By.Id("ConfirmPassword"));
            passwordConfirm.SendKeys("Abc1234");

            var registerButton = _driver.FindElement(By.Id("register-button"));
            registerButton.Click();


        }

        [TestCleanup] 
               public void TearDownTeast()
                {
                  Thread.Sleep(1000);  
            _driver.Quit();
                }
                
                    
                }
            }

            


        

    












        


        


        
       
    
    

