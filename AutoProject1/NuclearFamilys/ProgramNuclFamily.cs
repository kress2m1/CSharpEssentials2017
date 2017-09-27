using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuclearFamilys.OverloadedMethod;

namespace NuclearFamilys
{
   public class ProgramNuclearfamily 
    {
        private static bool newNameOfBirds;

        static void Main(string[] args)
        {
            Console.WriteLine("This is the main method from Program Nuclear Familys");
            MethodAndOverloading methodAndOverloading = new MethodAndOverloading();
            methodAndOverloading.AdditionMethod();
            Console.WriteLine("................");
            methodAndOverloading.AdditionMethod(44, 55);
            methodAndOverloading.AdditionMethod(100, 23);
            methodAndOverloading.AdditionMethod(25, 75);
            methodAndOverloading.AdditionMethod(44, 55);
            Console.WriteLine(".....................");
           //? methodAndOverloading.AdditionMethod(14,21,10);

            Console.WriteLine(".............");

            Birds birds = new Birds();
            Console.WriteLine(birds.getNameOfBird());
            Console.WriteLine(birds.getNumOfEyes());

            birds.setNameOfBird("Eagle");
            birds.setNumOfEyes(4);

            Console.WriteLine(birds.getNameOfBird());
            Console.WriteLine(birds.getNumOfEyes());






            Console.ReadKey();
        }
    }
}
