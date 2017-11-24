using System;
using eCommerce.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace eCommerce.BrowserFactory
{
    public class BrowserRepo
    {
        private IWebDriver _driver;
        public BrowserRepo InitializeBrowser()
        {
            var browser = OpenCartFramework.Default.Browser;

            if (browser.ToLower().StartsWith("chr") || 
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

        public void SetUpBrowser()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://wwww.opencart.com");
        }
    }
}
