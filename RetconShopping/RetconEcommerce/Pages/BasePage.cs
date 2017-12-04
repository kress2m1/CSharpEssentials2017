using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RetconShoppingProject.Configuration;

namespace RetconEcommerce.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);

        }

        public HomePage GoToHomePage()
        {
        //    Driver.Navigate().GoToUrl(OpenCartFramework.Default.BaseURL);
            Driver.Navigate().GoToUrl(RetconShoppingConfig.Default.BaseURL);
            return new HomePage(Driver);
        }
    }


    
}
