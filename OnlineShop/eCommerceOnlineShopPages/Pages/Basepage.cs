using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace eCommerceOnlineShopPages.Pages
{
    public class Basepage
    {
        protected IWebDriver Driver;

        public Basepage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
