using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CoopShoppingCom.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace CoopShoppingCom.BrowserFactory
{
    [TestClass]
    public class BrowserTest
 {
        private IWebDriver _driver;
       [TestInitialize]
        public BrowserTest InitializeBrowser()
          {
            var browser = CoopShoppingConfig.Default.Browser;

            if (browser.ToLower().StartsWith("chro") ||
                browser.ToLower().EndsWith("ome") ||
                browser.Equals("chrome"))
            {
                _driver = new ChromeDriver();
            }
            else if (browser.ToLower().StartsWith("Fire") ||
                     browser.EndsWith("Fox") ||
                     browser.ToLower().Equals("Firefox"))
            {
                _driver = new FirefoxDriver();
            }
            return new BrowserTest();
        }

        public void SetupBrowser()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.co-operativebank.co.uk/");
        }
    }
}













