using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.EcomOnlineShop.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Com.EcomOnlineShop.BrowserFactory
{
    public class BrowserUser
    {
        private IWebDriver _driver;

        public BrowserUser InitializeBrowser()
        {
            var browser = EcomShopConfig.Default.Browser;

            if (browser.ToLower().StartsWith("chr") ||
                browser.ToLower().EndsWith("ome") ||
                browser.ToLower().Equals("Chrome"))
            {
                _driver = new ChromeDriver();
                      
                    }
            else if (browser.ToLower().StartsWith("fire") ||
                browser.ToLower().EndsWith("fox") || 
                browser.ToLower().Equals("firefox"))
            {
                _driver = new FirefoxDriver();
            }
            return new BrowserUser();
                        
                    }

        public void SetUpBrowser()
        {
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("http://www.opencat.com");
        }
                }
            }
            
                
            
        
    

