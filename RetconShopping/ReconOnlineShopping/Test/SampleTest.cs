using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RetconShoppingProject.Hookes;

namespace RetconOnlineShoppingTest.Test
{
        [TestClass]
        public class SampleTest : CartHookes
        {
            [TestMethod]
            public void CheckHomePageTitle()
            {
                Console.WriteLine("Print Homepage Title");
            }


        }
    
}

