using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace eCommercePages.Pages
{
    public class Basepage
    {
        protected IWebDriver Driver;

        public Basepage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }
        

        public Homepage GoToHomePage()
        {
            Driver.Navigate().GoToUrl(OpenCartFramework.Default.BaseURL);   
            return new Homepage(Driver);
        }

        public void GoToCameraPage()
        {
            Driver.Navigate().GoToUrl(OpenCartFramework.Default.BaseURL);

        }
    }
}
