using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeenAuto_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("World");

            Console.WriteLine();    //this creates an empty space
            string name = "Anita";
            Console.WriteLine("My name is " + name);

            /**This is how
             * you write in
             * a multiline comment
             */
            int numOne = 55;
            int numTwo = 33;

            int result = numOne + numTwo + numTwo + numOne;
            Console.WriteLine("55 + 33 + 33 + 55 = " + result);

            Console.WriteLine();
            result = numTwo * numOne * numTwo * numOne;
            Console.WriteLine("This results in: " + result);

            Console.WriteLine();
            result = numTwo - numOne - numTwo - numOne;
            Console.WriteLine(result + " is 33 - 55 - 33 - 55");

            Console.WriteLine();
            double newResult = numTwo / numOne;
            Console.WriteLine(newResult);

            Console.WriteLine();
            newResult = numTwo % numOne;
            Console.WriteLine("33 % 55: " + newResult);

            //This is our if statement
            if (numTwo > numOne)
            {
                Console.WriteLine("numTwo is > numOne");
            }
            else
            {
                Console.WriteLine("numOne is < numTwo");
            }


            Console.ReadKey();

        }
    }
}
