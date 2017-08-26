using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family;

namespace C_Coding_Basics
{
    public class Dog 
    {
        //variables of object dog
        public int Eyes = 2;
        private int Legs = 4;
        private int Ears = 2;
        private int Tail = 1;
        private int Mouth = 1;

        //methods of object Dog

        //Our dog can eat
        public void Eat()
        {
            Console.WriteLine("I can eat");
        }

        public void Bark()
        {
            Console.WriteLine("I can bark");
        }

        public void Run()
        {
            Console.WriteLine("I can run");   
        }

        public void Drink()
        {
            Console.WriteLine("I can drink");   
        }
    }
}
