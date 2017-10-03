using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconciliationMethod.EndOfDayReconciliation
{
   public class SalesReconciliation
    {
         int salesOne=10000;
         int salesTwo=20000;
       string salesThree = "salesOne" + "salesTwo";
        public void TotalSales()

       {
           int salesThree = salesOne + salesTwo;
            Console.WriteLine("Total sales at end of Dayshift is:" + salesThree);    
       }

    }
}
