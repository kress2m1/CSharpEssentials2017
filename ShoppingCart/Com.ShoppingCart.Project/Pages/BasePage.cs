using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Com.ShoppingCart.Project.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage()
        {
        }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }
    }
}
