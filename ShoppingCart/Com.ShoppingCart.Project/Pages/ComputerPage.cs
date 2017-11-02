using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Com.ShoppingCart.Project.Pages
{
    public class ComputerPage : BasePage
    {
        public ComputerPage(IWebDriver driver) : base(driver)
        {
        }

        private string CPU;

        public LogOutPage SearchForPc()
        {
            //this code explains the mouseover action and how to select an element from the sub-menu
            var computerMenu = Driver.FindElement(By.LinkText("Computers"));

            var action = new Actions(Driver);
            action.MoveToElement(computerMenu).Build().Perform();
            Driver.FindElement(By.LinkText("Notebooks")).Click();
            return new LogOutPage(Driver);
        }
    }
}
