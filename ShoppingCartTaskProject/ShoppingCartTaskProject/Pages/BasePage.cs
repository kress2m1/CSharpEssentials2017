using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ShoppingCartTaskProject.Pages
{
    [TestClass]
    public class BasePage
    {
        protected IWebDriver Driver;

       public BasePage(IWebDriver driver)
       {
           Driver = driver;
            PageFactory.InitElements(Driver, this);
            
       }
    }
}
