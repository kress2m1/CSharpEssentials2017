using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedFamily.ExceptionHandler
{
    public class ExceptionManager
    {
        public void DivideMe(int a, int b)
        {
            try
            {
                var answer = a / b;
                Console.WriteLine(answer);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please see message" + e.Message);
                Console.WriteLine("Please see this message" + e.StackTrace);
                throw new Exception("Unable to divide by 0. Try again");
            }
        }
    }
}
