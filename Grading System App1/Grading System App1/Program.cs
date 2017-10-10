using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_System_App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your grade");
            float grade = float.Parse(Console.ReadLine());
            Console.ReadLine();

            if ((grade >= 0.00) && (grade <= 0.99))
            {
                Console.WriteLine("You have Failed and will repeat Class");               
            }
            else if ((grade >= 1.00) && (grade <= 1.99))
            {
                Console.WriteLine(" pass");
                Console.ReadLine();
            }

            else if ((grade >= 2.00) && (grade <= 2.99))
            {
                Console.WriteLine("Lower pass");
                Console.ReadLine();
            }
            else if ((grade >= 3.00) && (grade <= 3.99))
            {
                Console.WriteLine("Upper pass");
                Console.ReadLine();
            }
            else if ((grade >= 4.00) && (grade <= 4.99))
            {
                Console.WriteLine("Distinction");
                Console.ReadLine();
            }
            else if ((grade < 0.00) || (grade> 5.00))
            {
                Console.WriteLine("GRADES DO NOT EXIST, PLEASE ENTER A VALID GRADE NOTE");
                Console.ReadKey();
            }

           
           
        }
    }
}
