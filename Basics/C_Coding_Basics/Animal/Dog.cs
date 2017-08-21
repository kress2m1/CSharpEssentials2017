using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Coding_Basics
{
    class Dog
    {
        //variables of object dog
        int eyes = 2;
        int legs = 4;
        int ears = 2;
        int tail = 1;
        int mouth = 1;

        //methods of object Dog

        //Our dog can eat
        public void eat()
        {
            Console.WriteLine("I can eat");
        }

        public void bark()
        {
            Console.WriteLine("I can bark");
        }

        public void run()
        {
            Console.WriteLine("I can run");   
        }

        public void drink()
        {
            Console.WriteLine("I can drink");   
        }
    }
}
