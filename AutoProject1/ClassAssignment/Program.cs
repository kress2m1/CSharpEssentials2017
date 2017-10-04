using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a grade");
            float grades = float.Parse(Console.ReadLine());
            Console.ReadLine();


            if ((grades > 0.10) && (grades <= 0.99))
            {
                Console.WriteLine("FAIL YOU NEED TO REPEAT THE CLASS");
                Console.ReadLine();
            }
            else if ((grades > 1.00) && (grades <= 1.99))
            {
                Console.WriteLine("PASS");
                Console.ReadLine();

            }
            else if ((grades > 2.00) && (grades <= 2.99))
            {
                Console.WriteLine("LOWER CLASS");
                    Console.ReadLine();

            }
           else if ((grades > 3.00) && (grades <= 3.99))
            {
                Console.WriteLine("UPPER PASS");
                Console.ReadLine();
            }
            else if ((grades > 4.00) && (grades <= 5.00))
            {
                Console.WriteLine("DISTINCTION");
                Console.ReadLine();
            }
            else if ((grades >= 5.00))
            {
                Console.WriteLine("GRADE DO NOT EXIST,PLEASE ENTER A VALID GRADE NOTE");
                Console.ReadLine();
               

                Console.ReadKey();
            }
        }

    }
}
