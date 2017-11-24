using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceOnlineShop.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace eCommerceOnlineShop.BrowserFactory
{
    public class BrowserRepo
    {
        private IWebDriver _driver;

        public BrowserRepo InitializeBrowser()
        {
            var browser = eCommerceConfig.Default.Browser;

            if (browser.ToLower().StartsWith("chro") ||
                browser.ToLower().EndsWith("ome") ||
                browser.ToLower().Equals("chrome"))
            {
                _driver = new ChromeDriver();
            }
            else if (browser.ToLower().StartsWith("fire") || 
                browser.ToLower().EndsWith("fox") ||
                browser.ToLower().Equals("firefox"))
            {
                _driver = new FirefoxDriver();
            }
            return new BrowserRepo();
        }

        public IWebDriver SetupBrowser()
        {
            _driver.Manage().Window.Maximize();
            //_driver.Navigate().GoToUrl("http://www.opencart.com");
            return _driver;
        }

        public void CloseBrowser()
        {
            _driver?.Quit();
        }
    }
}
