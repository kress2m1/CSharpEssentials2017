using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Com.ShoppingCart.Project.Pages
{
    public class CreateAccount : BasePage
    {
        public CreateAccount(IWebDriver driver) : base(driver)
        {
        }

        public LoginPage RegisterAccount()
        {
            //click on register button
            var registerButton = Driver.FindElement(By.ClassName("ico-register"));
            registerButton.Click();

            //Assert register page is displayed
            var registerPage = Driver.Title;
            Assert.AreEqual(registerPage, "nopCommerce demo store. Register");

            //click Gender
            var maleGender = Driver.FindElement(By.Id("gender-male"));
            maleGender.Click();

            //enter firstname
            var firstName = Driver.FindElement(By.Id("FirstName"));
            firstName.SendKeys("Andre");

            //enter lastname
            var lastName = Driver.FindElement(By.Id("LastName"));
            lastName.SendKeys("Dada");

            //select Day of birth
            var dayOfBirth = Driver.FindElement(By.Name("DateOfBirthDay"));
            var selectDayOfBirth = new SelectElement(dayOfBirth);
            selectDayOfBirth.SelectByIndex(5);

            //select Month of birth
            var monthOfBirth = Driver.FindElement(By.Name("DateOfBirthMonth"));
            var selectMonthOfBirth = new SelectElement(monthOfBirth);
            selectMonthOfBirth.SelectByValue("6");

            //select Year of birth
            var yearOfBirth = Driver.FindElement(By.Name("DateOfBirthYear"));
            var selectYearOfBirth = new SelectElement(yearOfBirth);
            selectYearOfBirth.SelectByText("1980");

            //enter email
            var email = Driver.FindElement(By.Id("Email"));
            email.SendKeys("wale@hotmail.com");

            //tick newsletter checkbox
            var newsletterBox = Driver.FindElement(By.Id("Newsletter"));
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
            var password = Driver.FindElement(By.Id("Password"));
            password.SendKeys("welcome123");

            //confirm password
            var passwordConfirm = Driver.FindElement(By.Id("ConfirmPassword"));
            passwordConfirm.SendKeys("welcome123");

            //click register button
            var createAccountButton = Driver.FindElement(By.Id("register-button"));
            createAccountButton.Click();
            Thread.Sleep(3000);

            return new LoginPage(Driver);
        }
    }
}
