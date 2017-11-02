using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Com.ShoppingCartTask
{
    [TestClass]
    public class LoginUsers
    {
        private IWebDriver _driver; //we declare it outside the test method because 
        //we wnat to runn it somewhere else
        public TestContext TestContext { get; set; }


        [TestInitialize]
        public void SetUpTest()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://demo.nopcommerce.com/");
        }

        [TestMethod, TestCategory("Smoke")]
        // public void GetPageTitle()
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"C:\Users\omo akin\Documents\Automation2017\CSharpEssentials2017\ShoppingCartTask\userLoginDetailsPresideji.csv",
            "userLoginDetailsPresideji.csv",
            DataAccessMethod.Sequential)] //this is how to use datasource
        public void LogUserIn()
        {
            var username = TestContext.DataRow["username"] as string;
            var password = TestContext.DataRow["password"] as string;
            //selectlogin tab from the landing page
            var loginTab = _driver.FindElement(By.ClassName("ico-login"));
            loginTab.Click();

            //enter email
            var loginEmail = _driver.FindElement(By.Id("Email"));
            //   loginEmail.SendKeys("kala@yahoo.com"); // after the datasheet is atatched we do not need this any more
            loginEmail.SendKeys(username);
            //enter password
            var loginPassword = _driver.FindElement(By.Id("Password"));
            //  loginPassword.SendKeys("welcome123"); // after the datasheet is atatched we do not need this any more
            loginPassword.SendKeys(password);

            //click login button
            var loginButton = _driver.FindElement(By.ClassName("login-button"));
            loginButton.Click();

            //logout button
            var logoutButton = _driver.FindElement(By.ClassName("ico-logout"));
            Assert.IsTrue(logoutButton.Displayed); // check logout button is display
        }

        //------------------------------------------------------------------------
        [TestMethod, TestCategory("Smoke")]
        // public void GetPageTitle()
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"C:\Users\omo akin\Documents\Automation2017\CSharpEssentials2017\ShoppingCartTask\Com.ShoppingCartTask\DataFiles\invalidUserLoginDetailsPresideji.csv",
            "invalidUserLoginDetailsPresideji.csv",
            DataAccessMethod.Sequential)] //this is how to use datasource
        public void InvalidUserLogin()
        {
            var usernameOrig = TestContext.DataRow["username"] as string;
            var passwordOrig = TestContext.DataRow["password"] as string;

            //Debug.Assert(usernameOrig != null, "usernameOrig != null");
            var splitUsername = usernameOrig?.Split('-'); //make refrenece to the split in the note
           // Debug.Assert(passwordOrig != null, "passwordOrig != null");
            var splitPassword = passwordOrig?.Split('-');

            var username = splitUsername?[1];
            var password = splitPassword?[1];

            //select login tab from landing page
            var loginTab = _driver.FindElement(By.ClassName("ico-login"));
            loginTab.Click();

            //enter email
            var loginEmail = _driver.FindElement(By.Id("Email"));
            //loginEnail.Sendkeys("kala@gmail.com")
            loginEmail.SendKeys(username);

            //enter password
            var loginPassword = _driver.FindElement(By.Id("Password"));
            //loginPassword.Sendkeys("welcome123");
            loginPassword.SendKeys(password);


            //click login button
            var loginButton = _driver.FindElement(By.ClassName("login-button"));
            loginButton.Click();

            //   var logoutButton = _driver.FindElement(By.ClassName("ico-logout"));
            // if (logoutButton == null) throw new ArgumentNullException(nameof(logoutButton));

            // Assert.IsTrue(!logoutButton.Displayed);
        }

        [TestCleanup]
        public void TearDownTest()
        {
            //Thread.Sleep(10000); //it is a type of wait 
            _driver.Quit(); // will close everything
            //_driver.Close(); //will only close the most recent one
        }
    }
}