using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ShoppingCartTaskProject.Pages
{
    class PFModel :BasePage
    {
        //to do page factory
        [FindsBy(How = How.ClassName, Using = "ico-register")]
        //private IWebElement Login { get; set; }
        private IWebElement RegisterButton { get; set; }

        [FindsBy(How = How.Id, Using = "Login")]
        public IWebElement LoginButton { get; set; }

        public PFModel(IWebDriver driver) : base(driver)
        {
        }

        public void ClickRegisterButton()
        {
            //click on register button
            //var registerButton = Driver.FindElement(By.ClassName("ico-register"));
            //registerButton.Click();
            RegisterButton.Click();
        }
    }
}
