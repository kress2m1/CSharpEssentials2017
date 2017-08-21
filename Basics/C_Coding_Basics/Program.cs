using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Coding_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");
            //Console.WriteLine("World");

            //Console.WriteLine();    //this creates an empty space
            //string name = "Anita";
            //Console.WriteLine("My name is " + name);

            ///**This is how
            // * you write in
            // * a multiline comment
            // */
            //int numOne = 55;
            //int numTwo = 33;

            //int result = numOne + numTwo + numTwo + numOne;
            //Console.WriteLine("55 + 33 + 33 + 55 = " + result);

            //Console.WriteLine();
            //result = numTwo * numOne * numTwo * numOne;
            //Console.WriteLine("This results in: " + result);

            //Console.WriteLine();
            //result = numTwo - numOne - numTwo - numOne;
            //Console.WriteLine(result + " is 33 - 55 - 33 - 55");

            //Console.WriteLine();
            //double newResult = numTwo / numOne;
            //Console.WriteLine(newResult);

            //Console.WriteLine();
            //newResult = numTwo % numOne;
            //Console.WriteLine("33 % 55: " + newResult);

            ////This is our if statement
            //if (numTwo > numOne)
            //{
            //    Console.WriteLine("numTwo is > numOne");
            //}
            //else
            //{
            //    Console.WriteLine("numOne is < numTwo");
            //}

            //Console.WriteLine("Please enter a name:");
            //string userInput = Console.ReadLine();

            //if (userInput.Equals("Kay"))
            //{
            //    Console.WriteLine("Hello Kay");
            //}
            //else if (userInput.Equals("Titi"))
            //{
            //    Console.WriteLine("Welcome Titi");
            //}
            //else if (userInput.Equals("Ayo"))
            //{
            //    Console.WriteLine("Welcome Ayo");
            //}
            //else

            //{
            //    Console.WriteLine("Sound the alarm");
            //}

            ////SWITCH STATEMENT
            //Console.WriteLine("Please enter a food item");
            //string foodItem = Console.ReadLine();

            //switch (foodItem)
            //{
            //    case "Beans":
            //        Console.WriteLine("We have beans"); 
            //        break;
            //    case "Bread":
            //        Console.WriteLine("We have bread");
            //        break;
            //    default:
            //        Console.WriteLine("The food item entered is not sold here");
            //        break;  
            //}

            //int enterNumber = int.Parse(Console.ReadLine());
            //if (enterNumber > 0)
            //{
            //    Console.WriteLine("You have entered a number");
            //}
            //else
            //{
            //    Console.WriteLine("Wetin you enter?");
            //}

            //Console.WriteLine("Please enter a number: ");
            //string number = Console.ReadLine();
            //float numberConverted = float.Parse(number);

            //Console.WriteLine(numberConverted / 100);
            //Console.WriteLine(number + 100);

            /**
             * int == datatype
             * numberToBeChecked == variable name
             * 32 == the value assigned
             */

            //int numberToBeChecked = 32;

            //while (numberToBeChecked < 40)
            //{
            //    Console.WriteLine("Hello");
            //    numberToBeChecked = numberToBeChecked + 4;
            //}

            //Console.WriteLine("Hello, I am free!!");

            //Console.WriteLine("Please enter the patient name: ");
            //string patientName = Console.ReadLine();
            //Console.WriteLine("Only give insulin injection to Agnes");

            //do
            //{
            //    Console.WriteLine("Please give Insulin Injection");
            //    break;
            //} while (patientName.Equals("Agnes"));

            //Console.WriteLine("Do not give injection if patient is Bob");

            //FOR LOOP
            //double counter;

            //for (int counter = 0; counter <= 12; counter+=4)
            //{
            //    Console.WriteLine("My number is" + counter);
            //}

            //Console.WriteLine("Please enter your grades");
            //int grades = int.Parse(Console.ReadLine());

            //if ((grades >= 0) && (grades <= 9))
            //{
            //    Console.WriteLine("Failed Course");
            //}
            //else if ((grades >= 10) && (grades <= 20))
            //{
            //    Console.WriteLine("Passed");
            //} else
            //{
            //    Console.WriteLine("Who you be?");
            //}

            // Class --> Object = New Instance --> Constructor
            Dog husky = new Dog();
            Console.WriteLine("This is a Husky");
            husky.bark();

            Console.WriteLine();
            Console.WriteLine("This is a Hush Puppy");
            Dog hushPuppy = new Dog();
            hushPuppy.bark();
            hushPuppy.drink();
            hushPuppy.eat();

            Console.ReadKey();
        }
    }
}
