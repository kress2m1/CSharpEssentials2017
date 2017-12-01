using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewOnlineShop.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace NewOnlineShop.BrowserFactory
{
    public class BrowserRepo
    {
        private IWebDriver _driver;

       // public void InitializeBrowser()
        public BrowserRepo InitializeBrowser()

        {
            // the belwo help us to select browser to run test
            var browser = NewOnlineShopConfig.Default.Browser;

            if (browser.ToLower().StartsWith("chro") || 
                browser.ToLower().EndsWith("ome") ||
                browser.ToLower().Equals("chrome"))
                //if any of "chro" or "ome" equals "chrome" start "chromedriver"
            {
               _driver = new ChromeDriver(); 
            }
            else if (browser.ToLower().StartsWith("fire") ||
                     browser.ToLower().EndsWith("fox") ||
                     browser.ToLower().Equals("firefox"))
            {
                _driver = new FirefoxDriver();
            }
            //once the above is finish return
            return new BrowserRepo();
             
        }

        public IWebDriver SetUpBrowser()
        {
            _driver.Manage().Window.Maximize();
          //  _driver.Navigate().GoToUrl("http://www.opencart.com");//we
          //have put the above link in the settings file.When we need it
          //we will call the "BaseURL"
            return _driver;

        }
        //let us create something to close browser
        public void CloseBrowser()
        {
            _driver?.Quit();
        }
    }
}
