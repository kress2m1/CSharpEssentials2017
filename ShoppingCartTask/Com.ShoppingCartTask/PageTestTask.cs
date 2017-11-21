using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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
           // _driver = new FirefoxDriver();
            _driver.Manage().Window.Maximize();
            //_driver.Navigate().GoToUrl("http://www.next.co.uk");
            // _driver.Navigate().GoToUrl("http://automationpractice.com");
            _driver.Navigate().GoToUrl("http://demo.nopcommerce.com/");
        }

        [TestMethod, TestCategory("Smoke")]
       // public void GetPageTitle()
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
            firstName.SendKeys("Dejo");

            //enter lastname
            var lastName = _driver.FindElement(By.Id("LastName"));
            lastName.SendKeys("Boy");

            //select date of birth
            var dayOfBirth = _driver.FindElement(By.Name("DateOfBirthDay"));
            var selectDayOfBirth = new SelectElement(dayOfBirth);
            selectDayOfBirth.SelectByValue("6");

            //select Month of birth
            var monthOfBirth = _driver.FindElement(By.Name("DateOfBirthMonth"));
            var selectMonthOfBirth = new SelectElement(monthOfBirth);
            selectMonthOfBirth.SelectByIndex(6);

            //select Year of birth
            var yearOfBirth = _driver.FindElement(By.Name("DateOfBirthYear"));
            var selectYearOfBirth = new SelectElement(yearOfBirth);
            selectYearOfBirth.SelectByText("1980");

            //enter email
            var email = _driver.FindElement(By.Id("Email"));
            email.SendKeys("kala@yahoo.com");

            //tick newsletter checkbox
            var newsletterBox = _driver.FindElement(By.Id("Newsletter"));
            /**
            *This code below would be standard if the checkbox
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

            

            //Console.WriteLine("This is a test to get the page title");
            //let us take away the consolewriteline
            // var pageTitle = _driver.Title;
            // Assert.AreEqual(pageTitle, "Next Official Site: Online Fashion, Kids Clothes & Homeware", "The expected & actual don't match");
            //the above means run the code get the page title and compare it to
            //what i know it shd be "My Store"

            //decare wait method
            //var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            //_driver.FindElement(By.ClassName("login")).Click();
            //var signInPagetitle = _driver.Title;
            //Assert.AreEqual(signInPagetitle.ToLower(), "Login - My Store".ToLower());
            //convert all chracter to lower chracter

            //select email filed and send email address
            //email = _driver.FindElement(By.Id("email_create"));
            //email.SendKeys("kala@yahoo.com");

            //find submit button and click it
            //var submitButton = _driver.FindElement(By.Id("SubmitCreate"));
            //submitButton.Click();

            //Select the radio button for Mr
            //wait.Until(ExpectedConditions.ElementIsVisible(By.Id("id_gender1")));
            //var selectMr = _driver.FindElement(By.Id("id_gender1"));
            //selectMr.Click();

            ////enter firstname
            //wait.Until(ExpectedConditions.ElementIsVisible(By.Id("customer_firstname")));
            //var firstName = _driver.FindElement(By.Id("customer_firstname"));
            //firstName.SendKeys("Deji");

            ////Select Day of Birth
            //wait.Until(ExpectedConditions.ElementIsVisible(By.Id("days")));
            //var dayOfBirth = _driver.FindElement(By.Id("days"));
            //var selectDayOfBirth = new SelectElement(dayOfBirth);
            //selectDayOfBirth.SelectByValue("2");

            ////select month of birth
            //wait.Until(ExpectedConditions.ElementIsVisible(By.Id("months")));
            //var monthOfBirth = _driver.FindElement(By.Id("months"));
            //var selectMonthOfBirth = new SelectElement(monthOfBirth);
            //selectMonthOfBirth.SelectByIndex(4);

            ////select year of Birth
            //wait.Until(ExpectedConditions.ElementIsVisible(By.Id("years")));
            //var yearOfBirth = _driver.FindElement(By.Id("years"));
            //var selectYearOfBirth = new SelectElement(yearOfBirth);
            //selectYearOfBirth.SelectByValue("2");

            //select checkbox
            //wait.Until(ExpectedConditions.ElementIsVisible(By.Id("newsletter")));
            //var newsletterSignUp = _driver.FindElement(By.Id("newsletter"));
            //newsletterSignUp.Click();


        }

        [TestMethod, TestCategory("UAT")]
        public void CheckForCookies()
        {
            //var allcookies = _driver.Manage().Cookies.AllCookies;
            //foreach (var cookies in allcookies)//get me all cookies and i will check for it
            //{
            //    Console.WriteLine("The List of cookies are {0}", cookies.ToString());
            //}
        }

        [TestMethod]
        public void ConfirmUserOnHomePage()
        {
            //var ContactUs = _driver.PageSource.ToLower().Contains("Contact us".ToLower());
            ////go to the page source change it to lower, confirm it has contactus 
            ////change it to lower
            //Assert.IsTrue(ContactUs);

        }

        [TestCleanup]
        public void TearDownTest()
        {
            Thread.Sleep(10000); //it is a type of wait 
            _driver.Quit(); // will close everything
           //_driver.Close(); //will only close the most recent one

        }
    }
}
