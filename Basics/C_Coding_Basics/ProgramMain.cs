using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Coding_Basics.Humans;
using Family;


namespace C_Coding_Basics
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            
            // Class --> Object = New Instance --> Constructor
            Dog husky = new Dog();
            Console.WriteLine("This is a Husky");
            husky.Bark();

            Console.WriteLine();
            Console.WriteLine("This is a Hush Puppy");
            Dog hushPuppy = new Dog();
            hushPuppy.Bark();
            hushPuppy.Drink();
            hushPuppy.Eat();

            Human humansTeen = new Human();
            humansTeen.PullDetailsFromTeenager();


            Console.ReadKey();
        }
    }
}
