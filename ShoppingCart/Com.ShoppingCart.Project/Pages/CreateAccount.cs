﻿using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Com.ShoppingCart.Project.Pages
{
    public class CreateAccount
    {
        private readonly IWebDriver _driver;

        //create a constructor of IWebDriver       
        public CreateAccount(IWebDriver driver)
        {
            _driver = driver;
        }

        public void RegisterAccount()
        {
            //click on register button
            var registerButton = _driver.FindElement(By.ClassName("ico-register"));
            registerButton.Click();

            //Assert register page is displayed
            var registerPage = _driver.Title;
            Assert.AreEqual(registerPage, "nopCommerce demo store. Register");

            //click Gender
            var maleGender = _driver.FindElement(By.Id("gender-male"));
            maleGender.Click();

            //enter firstname
            var firstName = _driver.FindElement(By.Id("FirstName"));
            firstName.SendKeys("Andre");

            //enter lastname
            var lastName = _driver.FindElement(By.Id("LastName"));
            lastName.SendKeys("Dada");

            //select Day of birth
            var dayOfBirth = _driver.FindElement(By.Name("DateOfBirthDay"));
            var selectDayOfBirth = new SelectElement(dayOfBirth);
            selectDayOfBirth.SelectByIndex(5);

            //select Month of birth
            var monthOfBirth = _driver.FindElement(By.Name("DateOfBirthMonth"));
            var selectMonthOfBirth = new SelectElement(monthOfBirth);
            selectMonthOfBirth.SelectByValue("6");

            //select Year of birth
            var yearOfBirth = _driver.FindElement(By.Name("DateOfBirthYear"));
            var selectYearOfBirth = new SelectElement(yearOfBirth);
            selectYearOfBirth.SelectByText("1980");

            //enter email
            var email = _driver.FindElement(By.Id("Email"));
            email.SendKeys("wale@hotmail.com");

            //tick newsletter checkbox
            var newsletterBox = _driver.FindElement(By.Id("Newsletter"));
            /**
             * This code below would be standard if the checbox 
             * for newsletter was never ticked by default
             */
            //newsletterBox.Click(); 

            if (!newsletterBox.Selected)
            {
                newsletterBox.Click();
            }

            //enter password
            var password = _driver.FindElement(By.Id("Password"));
            password.SendKeys("welcome123");

            //confirm password
            var passwordConfirm = _driver.FindElement(By.Id("ConfirmPassword"));
            passwordConfirm.SendKeys("welcome123");

            //click register button
            var createAccountButton = _driver.FindElement(By.Id("register-button"));
            createAccountButton.Click();
            Thread.Sleep(3000);
        }
    }
}