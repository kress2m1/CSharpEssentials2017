﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_C_Coding_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("World");
            //string welcome = "Hello World";
            //string name = "Anita";
            //Console.WriteLine(name);
            Console.WriteLine(); //this is used to creat an empty space

            /** this sis how you write in
             * a multiline
             * comment
             */

            //float numOne = 2;
           // int numOne = 2;
            int numOne = 55;
           // int numTwo = 3; //numTwo has been wriitten using camel casing
            //float numTwo = 3;
            int numTwo = 33;

            //double result = numOne + numTwo + numTwo + numOne;
            int result = numOne + numTwo + numTwo + numOne;
            Console.WriteLine("55 + 33 + 33 + 55 = " + result); //when using a variable you do not put it in quotation mark

            Console.WriteLine();
            result = numTwo * numOne * numTwo * numOne;
            Console.WriteLine("This result in:" + result);

            Console.WriteLine();
            result = numTwo - numOne - numTwo - numOne;
            Console.WriteLine(result + " is 33 - 55 - 33 - 55");

            Console.WriteLine();
            double newResult = numTwo / numOne; //accepts double because it is bigger than int.
            //when aiming for precision use float
            Console.WriteLine(newResult);

            Console.WriteLine();
            newResult = numTwo % numOne;
            Console.WriteLine("33 % 55: " + newResult);

            bool maxNum = true;
            Console.WriteLine(maxNum);

            //This is our if statement
            if (numTwo > numOne) //this is booloean
            {
                Console.WriteLine("numTwo is > numOne");
            }
            else
            {
                Console.WriteLine("numOne is < numTwo");
            }


            //Console.ReadKey();


            Console.WriteLine(); //this creates an empty space

            Console.Write("Hello");
            Console.Write(" "); //this creates a space between the word "Hello" and "World". so we have Hello World
            Console.Write("World");
            string name = "Anita";
            Console.WriteLine("My name is " + name);

            Console.ReadKey(); //read any key that user press
        }
    }
}
