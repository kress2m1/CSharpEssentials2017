using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AutoProject1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");

            Console.WriteLine("World");

            Console.WriteLine();
            string name = "Rachael";
            Console.WriteLine("My name is" + name);




            Console.WriteLine();
            int numOne = 10;
            int numTwo = 30;
            int result = numOne + numTwo;
            Console.WriteLine(result);

            Console.WriteLine();
            result = numOne + numTwo;
            Console.WriteLine(result);

            Console.WriteLine();
            result = numOne*numTwo;
            Console.WriteLine( result);

            Console.WriteLine();
            result = numTwo - numOne;
            Console.WriteLine(result);

            Console.WriteLine();
            Double newResult = numTwo/numOne;
            Console.WriteLine( newResult);

            Console.WriteLine();
            newResult = numTwo%numOne;
            Console.WriteLine("30 % 10:" + newResult);


            Console.WriteLine();

            Boolean maxNum = true;
            Console.WriteLine(maxNum);


            Console.WriteLine();
            result = numTwo + numOne + numTwo + numOne;
            Console.WriteLine(result);

            Console.WriteLine();
            result = numOne - numTwo - numOne - numTwo;
            Console.WriteLine(result);

            Console.WriteLine();
            result = numTwo*numOne*numTwo*numOne;
            Console.WriteLine(result);

            Console.WriteLine();


            Console.ReadKey();



        }
    }
}
