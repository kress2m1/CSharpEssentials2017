using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ThrowAway.StepDefs
{
    [Binding]
    public sealed class AddDef
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            
        }

        [When(@"I press the add button")]
        public void WhenIPressTheAddButton()
        {
            
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            
        }

        [Given(@"I press the subtract button")]
        public void GivenIPressTheSubtractButton()
        {
            
        }

    }
}
