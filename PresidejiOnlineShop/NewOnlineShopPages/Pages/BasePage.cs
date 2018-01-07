using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewOnlineShop.Configuration;
using OpenQA.Selenium;

namespace NewOnlineShopPages.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void GoToHomePage()
        {
            Driver.Navigate().GoToUrl(NewOnlineShopConfig.Default.BaseURL);
        }
    }
}
