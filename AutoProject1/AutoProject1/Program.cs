using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
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
            result = numOne * numTwo;
            Console.WriteLine(result);

            Console.WriteLine();
            result = numTwo - numOne;
            Console.WriteLine(result);

            Console.WriteLine();
            Double newResult = numTwo / numOne;
            Console.WriteLine(newResult);

            Console.WriteLine();
            newResult = numTwo % numOne;
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
            result = numTwo * numOne * numTwo * numOne;
            Console.WriteLine(result);

            Console.WriteLine();



           // if Statement

            if (numOne < numTwo)

                {
                    Console.WriteLine("numTwo < numOne");
                }

                else if (numOne > numTwo)

                {
                    Console.WriteLine("numOne is > numTwo");
                }

            Console.WriteLine("please enter a name:");
            string userInput = Console.ReadLine();
            string anotherInput = Console.ReadLine();


            if (userInput.Equals("Kay") || userInput.Equals("Tinu"))

                if (userInput.Equals("Kay") && anotherInput.Equals("Tinu"))

                {
                    Console.WriteLine("Hello Kay");
                }
                else
                {
                    Console.WriteLine("sound the alarm");
                }

            else if (userInput.Equals("Tola"))

            {
                Console.WriteLine(" Welcome Tola");
            }

            else if (userInput.Equals("Tope"))


            {
                Console.WriteLine("Welcome Tope");
            }

            //switch statatement
            Console.WriteLine("Please enter food item");
            string foodItem = Console.ReadLine();
            switch (foodItem)
            {
                case "Beans":

                    Console.WriteLine("we have beans");
                    break;
            }

            switch (foodItem)
            {
                case "Bread":

                    Console.WriteLine("we have bread");

                    break;
            }
            switch (foodItem)
            {
                case "EBA":

                default:
                    Console.WriteLine("the food item is not sold here");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Please enter a number:");
            string number = Console.ReadLine();
            int numberConverted = int.Parse(number);

            Console.WriteLine(numberConverted + 100);
            Console.WriteLine(number + 100);


            int numbertobechecked = 40;
            while (numbertobechecked < 40)
            {
                Console.WriteLine("Hello");
                numbertobechecked = numbertobechecked + 1;
            }
            Console.WriteLine("Hello I am free");

            Console.WriteLine("Please enter the patient name");
            string patientName = Console.ReadLine();
            Console.WriteLine("only give insulin injection to Topy");
            do
            {
             Console.WriteLine("Please give insulin injection");
            }
            while (patientName.Equals("Topy"));

            Console .WriteLine("Do not give while patient name is Bob");
             
            
          
            for (int summit = 0; summit < 14; summit++)
            {
                Console.WriteLine("my number is + summit");
            }
            Console.ReadKey();

        }
    }
}
