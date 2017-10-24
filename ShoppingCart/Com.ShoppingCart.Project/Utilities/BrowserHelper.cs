using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Com.ShoppingCart.Project.Utilities
{
    public class BrowserHelper
    {
        private IWebDriver _driver;

        public IWebDriver LaunchBrowser()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://demo.nopcommerce.com/");
            return _driver;
        }

        public void CloseBrowser()
        {
            _driver.Quit();
        }
    }
}
