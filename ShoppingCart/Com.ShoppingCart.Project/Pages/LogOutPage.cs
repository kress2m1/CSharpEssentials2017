using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Com.ShoppingCart.Project.Pages
{
    public class LogOutPage:BasePage
    {
        
        public LogOutPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly By _logOutButton = By.ClassName("ico-logout");

        public void LogUserOut()
        {
            Driver.FindElement(_logOutButton).Click();
        }
        

    }
}
