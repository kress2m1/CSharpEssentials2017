using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your grade");
            float grade = float.Parse(Console.ReadLine());
            Console.WriteLine();

            if ((grade>0.1) && (grade<0.99))
            {
                Console.WriteLine("Fail you need to repat the class");
                Console.ReadLine();
            }
            else if ((grade >0.99) ||(grade<1.99))
            {
                Console.WriteLine("pass");
                Console.ReadLine();
            }
            else if ((grade > 1.99) || (grade < 2.99))
            {
                Console.WriteLine("lower pass");
                Console.ReadLine();
            }
        }
    }
}
