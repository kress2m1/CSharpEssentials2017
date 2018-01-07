using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RetconShoppingProject.Configuration;

namespace RetconShoppingProject.BrowserFactory
{
    public class Browser
    {
        private IWebDriver _driver;

        public Browser InitializeBrowser()

        {
            var browser = RetconShoppingConfig.Default.Browser;
            if (browser.ToLower().StartsWith("Chro") ||
            browser.ToLower().EndsWith("ome") ||
            browser.ToLower().EndsWith("chrome"))
           
            {
                _driver = new ChromeDriver();
            }
            else if (browser.ToLower().StartsWith("fire") ||
                browser.ToLower().EndsWith("fox") ||
                browser.ToLower().Equals("firefox"))
            {
                _driver = new FirefoxDriver();
            }
            return new Browser();
        }

        public IWebDriver SetupBrowser()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.opencart.com");
            return _driver;
        }

        public void CloseBrowser()
        {
            _driver?.Quit();
        }
    }
}

     
