using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewNewclearFamily.OverloadedMethods;
using New_C_Coding_Class;

namespace NewNewclearFamily
{
    public class ProgramFamily : MyFamily
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the main method from the program Family");

            MethodAndOverloading methodAndOverloading = new MethodAndOverloading(); // we instatnciated a new method of overloading
            //methodsAndOverloading.AdditionMethod();
            methodAndOverloading.AdditionMethod();
            Console.WriteLine(".............");
            methodAndOverloading.AdditionMethod(44, 55);
            methodAndOverloading.AdditionMethod(100, 23);
            methodAndOverloading.AdditionMethod(25, 78);
            methodAndOverloading.AdditionMethod(44, 28);
            Console.WriteLine(".............");
            methodAndOverloading.AdditionMethod(14, 21, 10);



            Console.ReadKey();


        }

    }



}
