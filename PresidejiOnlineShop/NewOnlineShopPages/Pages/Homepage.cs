using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NewOnlineShopPages.Pages
{
    public class Homepage : BasePage //it has inherit the base page
    {
        public Homepage(IWebDriver driver) : base(driver)
        {
        }
    }
}
