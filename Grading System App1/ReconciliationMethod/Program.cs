using ReconciliationMethod.EndOfDayReconciliation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconciliationMethod
{
    class Program
    {
        
        static void Main(string[] args)

        {
           SalesReconciliation salesReconciliation = new SalesReconciliation();
           salesReconciliation.TotalSales();
           //string salesThree = TotalSales;
           // Console.WriteLine("Total sales at end of Dayshift is:" + salesThree);

            Console.ReadLine();
        }
    


    }
}
