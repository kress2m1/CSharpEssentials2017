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
        public int Eyes;
        private int _legs;
        private int _ears;
        private int _tail;
        private int _mouth;

        //this is a constructor of the class
        public Dog(int eyes, int legs, int ears, int tail, int mouth)
        {
            Eyes = eyes;
            _legs = legs;
            _ears = ears;
            _tail = tail;
            _mouth = mouth;
        }

        //methods of object Dog

        //Our dog can eat
        public void Eat()
        {
            Console.WriteLine("I can eat");
            Console.WriteLine("The do has " + Eyes + " and " + _legs + " legs");
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
