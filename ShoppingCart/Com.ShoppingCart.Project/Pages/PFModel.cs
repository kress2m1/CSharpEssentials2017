using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Com.ShoppingCart.Project.Pages
{
    public class PFModel :BasePage
    {
        [FindsBy(How = How.ClassName, Using = "ico-register")]
        private IWebElement RegisterButton { get; set; }

        public PFModel(IWebDriver driver) : base(driver)
        {
        }

        public void ClickRegisterButton()
        {
            //click on register button
            RegisterButton.Click();
        }
    }
}
