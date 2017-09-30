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
            Console.WriteLine(".............");
            Birds birds = new Birds();
            //we get rid of it because it is complaining as a result of getters n setters
            //string newflameOfBirds = birds.NameOfBird;
            //newflameOfBirds = "Parrots";
            //Console.WriteLine(newflameOfBirds);
            
            //birds.GetNameOfBird();
            //birds.GetNumOfEyes();

            Console.WriteLine(birds.GetNameOfBird());
            Console.WriteLine(birds.GetNumOfEyes());

            birds.SetNameOfBird("Eagle");
            birds.SetNumOfEyes(4);

            Console.WriteLine(birds.GetNameOfBird());
            Console.WriteLine(birds.GetNumOfEyes());



            Console.ReadKey();


        }

    }



}
