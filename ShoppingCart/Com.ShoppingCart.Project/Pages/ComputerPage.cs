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

        private string _cPUType = "Intel Core i5";
        private string _memory = "8 GB";

        public LogOutPage SearchForPc()
        {
           //
            var computerMenu = Driver.FindElement(By.LinkText("Computers"));

            //this code explains the mouseover action and how to select an element from the sub-menu
            var action = new Actions(Driver);
            action.MoveToElement(computerMenu).Build().Perform();
            Driver.FindElement(By.LinkText("Notebooks")).Click();
            return new LogOutPage(Driver);
        }

        public void SearchForPcAndAssert()
        {
            //
            var computerMenu = Driver.FindElement(By.LinkText("Computers"));

            //this code explains the mouseover action and how to select an element from the sub-menu
            var action = new Actions(Driver);
            action.MoveToElement(computerMenu).Build().Perform();
            Driver.FindElement(By.LinkText("Notebooks")).Click();

            //Select Notebook by CPU type
            Driver.FindElement(By.LinkText(_cPUType)).Click();

            //Select Notebook by Memory size
            Driver.FindElement(By.LinkText(_memory)).Click();
        }

        public bool ValidateResult(string item)
        {
            return Driver.PageSource.Contains(item);
        }
    }
}
