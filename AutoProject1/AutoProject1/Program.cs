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
        private static void Main(string[] args)
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
            Console.WriteLine(result);

            Console.WriteLine();
            result = numTwo - numOne;
            Console.WriteLine(result);

            Console.WriteLine();
            Double newResult = numTwo/numOne;
            Console.WriteLine(newResult);

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



            // if Statement

            //    if (numOne < numTwo) ;
            //    {

            //    }


            //        Console.WriteLine("numTwo < numOne");

            //else
            //    {
            //        Console.WriteLine("numOne is > numTwo");
            // }

        Console .WriteLine("please enter a number:");
            string userInput = Console.ReadLine();

            if (userInput.Equals("Kay") || userInput.Equals("Tinu"))
            // if (userInput.Equals("Kay") && userInput.Equals("Tinu"))
            {
                Console.WriteLine("Hello Kay");
            }
            else
            {
                Console.WriteLine("sound the alarm");

            }

            {
            else if (userInput.Equals("Tola"));
            }

            {
               Console.WriteLine(" Welcome Tola");
            }
            {
                else
                if (userInput.Equals("Tope")) ;
            }
            {
                Console.WriteLine("Welcome Tope");
            }
            //switch statatement
            Console.WriteLine("Please enter food item");
            string foodItem = Console.ReadLine();
            switch (foodItem)
            
                case "Beans":
         
            Console.WriteLine("we have beans");
             break;
            case "Bread":
                Console.WriteLine("we have bread");
            break;
            default:
                Console.WriteLine("the food item is not sold here");
            break;


            Console.ReadKey();



        }
    }
}
