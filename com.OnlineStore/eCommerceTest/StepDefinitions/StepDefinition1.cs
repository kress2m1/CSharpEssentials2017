using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eCommerce.Configuration;
using eCommercePages.Pages;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace eCommerceTest.StepDefinitions
{
    [Binding]
    public sealed class StepDefinition1
    {
        [Given(@"I am on the opencart landing page")]
        public void GivenIAmOnTheOpencartLandingPage()
        {
            Basepage basepage = new Basepage(new ChromeDriver());
            basepage.GoToHomePage();
        }
    }
}
