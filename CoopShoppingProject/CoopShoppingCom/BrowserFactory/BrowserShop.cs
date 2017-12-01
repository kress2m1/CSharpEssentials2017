using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CoopShoppingCom.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace CoopShoppingCom.BrowserFactory
{
    public class BrowserShop
    {
        private IWebDriver _driver;

        public BrowserShop InitializeBrowser()
        {
           var browser = CoopShoppingConfig.Default.Browser;

            if (browser.ToLower().StartsWith("chro") ||
                browser.ToLower().EndsWith("ome") ||
                browser.ToLower().Equals("Chrome"))
            {
                _driver = new ChromeDriver();
               }
            else if (browser.ToLower().StartsWith("Fire") ||
                     browser.ToLower().EndsWith("Fox") ||
                     browser.ToLower().Equals("FireFox"))
            {
                _driver = new FirefoxDriver();
            }
              return new BrowserShop();
           }
            public void SetUpBrowser()
           {
            _driver.Manage().Window.Maximize();

           //driver.Navigate().GoToUrl("http://www.co-operativebank.co.uk/");
           }
        public void CloseBrowser()
         {
                _driver?.Quit();
         }
           
        }

    }


