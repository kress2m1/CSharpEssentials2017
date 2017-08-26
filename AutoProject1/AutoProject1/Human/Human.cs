using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProject1
{
    class Human
    {
        // Properties of Human
         int numberofHead = 1;
         int numberofLegs = 2;
         int numberofEyes = 2;
         int numberofFingers = 10;
         int numberofTeeth = 32;

       // MethodAccessException/Objects
        public void talk()
        {
            Console.WriteLine("I can Talk");
        }

        public void see()
        {
            Console.WriteLine(" I can see");
        }

        public void eat()
        {
            Console.WriteLine("I can eat");
        }

        public void walk()
        {
            Console.WriteLine("I can walk");
        }
    }
}
