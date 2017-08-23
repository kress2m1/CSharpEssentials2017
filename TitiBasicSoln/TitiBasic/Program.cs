using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitiBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Console.WriteLine("Hello");         //This  is introduction to Csharp
            //            Console.WriteLine("Bryan Divas");

            //            Console.Write("Hello");
            //            Console.Write("Bryan");


            //            Console.WriteLine();
            //            string name = "Titi";

            //            Console.WriteLine("My name is " + name);

            //            string welcome = "Hello Bryan Divas";
            //            Console.WriteLine(welcome);

            //            Console.WriteLine();
            //            Console.WriteLine();


            //            //This is Mathematical function
            //            //Addition with concartination
            //            int numOne = 20;
            //            int numTwo = 30;
            //            int result = numOne + numTwo;
            //            Console.WriteLine("20 + 30 = " + result);

            //            result = numOne * numTwo;
            //            Console.WriteLine("This result in: " + result);
            //            result = numTwo - numOne;
            //            Console.WriteLine(result);

            //            Console.WriteLine();
            //            double newResult = numTwo / numOne;
            //            Console.WriteLine(newResult);

            //            Console.WriteLine();
            //            newResult = numTwo % numOne;
            //            Console.WriteLine("30 % 20 = " + newResult);


            //           // This is if statement

            //            if (numTwo < numOne)
            //                {
            //                    Console.WriteLine("numoTwo is > numOne");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("numOne is < numTwo");

            //                }
            //            Console.WriteLine("Please enter a name:");
            //            string userInput = Console.ReadLine();
            //            string anotherInput = Console.ReadLine();

            //            if (userInput.Equals("Titi") && anotherInput.Equals("Bond"))

            //            {
            //                Console.WriteLine("Welcome Titi");

            //            }
            //            else if (userInput.Equals("Kay"))
            //            {
            //                Console.WriteLine("Welcome Kay");
            //            }
            //            else if (userInput.Equals("Ayo"))
            //            {
            //                Console.WriteLine("Welcome Ayo");
            //            }
            //            else
            //            {

            //                Console.WriteLine("Sound the Alarm");
            //            }




            //            {
            //                Console.WriteLine("Sound the alarm");
            //            }

            //           // SWITCH STATEMENT

            //                        Console.WriteLine("Please enter a food item");
            //            string foodItem = Console.ReadLine();

            //            switch (foodItem)
            //            {
            //                case "Beans":
            //                    Console.WriteLine("We have beans");
            //                    break;
            //                case "Bread":
            //                    Console.WriteLine("We have bread");
            //                    break;
            //                default:
            //                    Console.WriteLine("The food item entered is not sold here");
            //                    break;
            //                              }


            //                    Console.WriteLine("Please enter a nunber:");

            //            string number = Console.ReadLine();
            //            int numberconverted = int.Parse(number);
            //            Console.WriteLine(numberconverted + 100);
            //            Console.WriteLine(number + 100);



            //CONTROL STATEMENT
            //int numbercheck = 40;
            //while (numbercheck < 45)
            //{
            //    Console.WriteLine("Hello");
            //    numbercheck = numbercheck + 1;

            //}

            //Console.WriteLine("Hello i am free");

            ////Console.WriteLine("Please enter a patient name");
            ////string patientname = Console.ReadLine();
            ////Console.WriteLine("please give insulin to Titi");
            ////do
            ////{
            ////    Console.WriteLine("Please give Insulin Injection");
            ////    break;

            ////} while (patientname.Equals("Titi"));
            ////Console.WriteLine("Do not give injection if patient is Sarah");

            // for LOOP
            //double counter;
            for (int counter = 0; counter < 12; counter+=4)
            {
                Console.WriteLine("My nunber is " + counter);           
                    }

                Console.ReadKey();

        }
    }
}















