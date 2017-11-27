using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RetconShoppingProject.Hookes;

namespace ReconOnlineShopping.Test
{
        [TestClass]
        public class SampleTest : CartHookes
        {

            [TestInitialize]
            public void InitializeBrowser()
            {

            }

            [TestMethod]
            public void CheckHomePageTitle()
            {
                Console.WriteLine("Print Homepage Title");
            }


        }
    
}

