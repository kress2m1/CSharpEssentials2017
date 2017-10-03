using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoProject1.Arrays;
using ExtendedFamilies.Cousins;
using ExtendedFamilies.Nieces;


namespace AutoProject1
{
    class ProgramMain
    {
        private static void Main(string[] args)
        {

            //Console.WriteLine("Hello");

            //Console.WriteLine("World");

            //Console.WriteLine();
            //string name = "Rachael";
            //Console.WriteLine("My name is" + name);




            //Console.WriteLine();
            //int numOne = 10;
            //int numTwo = 30;
            //int result = numOne + numTwo;
            //Console.WriteLine(result);

            //Console.WriteLine();
            //result = numOne + numTwo;
            //Console.WriteLine(result);

            //Console.WriteLine();
            //result = numOne * numTwo;
            //Console.WriteLine(result);

            //Console.WriteLine();
            //result = numTwo - numOne;
            //Console.WriteLine(result);

            //Console.WriteLine();
            //Double newResult = numTwo / numOne;
            //Console.WriteLine(newResult);

            //Console.WriteLine();
            //newResult = numTwo % numOne;
            //Console.WriteLine("30 % 10:" + newResult);


            //Console.WriteLine();

            //Boolean maxNum = true;
            //Console.WriteLine(maxNum);


            //Console.WriteLine();
            //result = numTwo + numOne + numTwo + numOne;
            //Console.WriteLine(result);

            //Console.WriteLine();
            //result = numOne - numTwo - numOne - numTwo;
            //Console.WriteLine(result);

            //Console.WriteLine();
            //result = numTwo * numOne * numTwo * numOne;
            //Console.WriteLine(result);

            //Console.WriteLine();



            // if Statement

            //if (numOne < numTwo)

            //    {
            //        Console.WriteLine("numTwo < numOne");
            //    }

            //    else if (numOne > numTwo)

            //    {
            //        Console.WriteLine("numOne is > numTwo");
            //    }

            //Console.WriteLine("please enter a name:");
            //string userInput = Console.ReadLine();
            //string anotherInput = Console.ReadLine();


            //if (userInput.Equals("Kay") || userInput.Equals("Tinu"))

            //    if (userInput.Equals("Kay") && anotherInput.Equals("Tinu"))

            //    {
            //        Console.WriteLine("Hello Kay");
            //    }
            //    else
            //    {
            //        Console.WriteLine("sound the alarm");
            //    }

            //else if (userInput.Equals("Tola"))

            //{
            //    Console.WriteLine(" Welcome Tola");
            //}

            //else if (userInput.Equals("Tope"))


            //{
            //    Console.WriteLine("Welcome Tope");
            //}

            //switch statatement
            //Console.WriteLine("Please enter food item");
            //string foodItem = Console.ReadLine();
            //switch (foodItem)
            //{
            //    case "Beans":

            //        Console.WriteLine("we have beans");
            //        break;
            //}

            //switch (foodItem)
            //{
            //    case "Bread":

            //        Console.WriteLine("we have bread");

            //        break;
            //}
            //switch (foodItem)
            //{
            //    case "EBA":

            //    default:
            //        Console.WriteLine("the food item is not sold here");
            //        break;
            //}

            //Console.WriteLine();
            //Console.WriteLine("Please enter a number:");
            //string number = Console.ReadLine();
            //int numberConverted = int.Parse(number);

            //Console.WriteLine(numberConverted + 100);
            //Console.WriteLine(number + 100);


            //int numbertobechecked = 32;
            //while (numbertobechecked < 40)
            //{
            //    Console.WriteLine("Hello");
            //    numbertobechecked = numbertobechecked + 1;
            //}
            //Console.WriteLine("Hello I am free");

            //Console.WriteLine("Please enter the patient name");
            //string patientName = Console.ReadLine();
            //Console.WriteLine("only give insulin injection to Topy");
            //do
            //{
            // Console.WriteLine("Please give insulin injection");
            //}
            //while (patientName.Equals("Topy"));

            //Console .WriteLine("Do not give while patient name is Bob");



            //for (int summit = 0; summit < 14; summit ++)
            //{
            //    Console.WriteLine("my number is + summit");
            //}
            //int D = 4;
            //int R = 8;
            //Console.WriteLine(D < R);
            //Console.WriteLine(R >= D);

            // Assignment

            //   Console.WriteLine("Please enter a grade");
            //   double grades = Double.Parse(Console.ReadLine());

            //if ((grades >=0.00) && (grades <= 0.99 ))
            //   {
            //      Console.WriteLine("FAILED COURSE");
            //   }

            //class, followed by Object,and new instance

            // Cat husky = new Cat();
            // husky.mew();
            //Console.WriteLine("This is a husky");

            // Console.WriteLine();
            // Console.WriteLine("This is hushpuppy");
            // Cat hushpuppy = new Cat();
            // hushpuppy .mew();
            // hushpuppy.drink();
            // hushpuppy.eat();

            // Console.WriteLine();

            // Human Bobby = new Human();
            // Bobby.talk();
            // Bobby.walk();
            // Bobby.see();
            // Bobby.eat();

            //Youngsters youngsters = new Youngsters();
            //youngsters.MyName();

            // NiecesClass niece = new NiecesClass();
            // niece.DisplayNieceName();

            //// CounsinsClass
            //CousinsClass cousinsClass = new CousinsClass();
            //cousinsClass.DisplayNieceName();
            //cousinsClass.CallNiecefriendsName();
            //cousinsClass.CallDetailsForNiece();

            ////// GrandParentsClass
            //GrandParentsClass grandParentsClass =new GrandParentsClass();
            

            //string myGrandPapa = grandParentsClass.GrandFather;
            // {
            // //   int myGrandPapa = 0;
            // Console.WriteLine("My grand fathers name is {0} and " +
            //      "my friends name is {1}",myGrandPapa,grandParentsClass);
            //  }

            ////MethodAndOverloading
            //MethodAndOverloading methodAndOverloading = new MethodAndOverloading();
            //methodAndOverloading.AdditionMethod();
            //Console.WriteLine("........");
            //methodAndOverloading.AdditionMethod(48, 50, 20);
            //methodAndOverloading.AdditionMethod(100, 23);
            //methodAndOverloading.AdditionMethod(25, 78);
            //methodAndOverloading.AdditionMethod(44, 28);
            //Console.WriteLine(".......................");

            // StudentGrades studentgradesclass = new StudentGrades();

            ArrayClass arrayClass = new ArrayClass();
            arrayClass.AgeofPatients();
            arrayClass.TeacherName();
            arrayClass.CourseNames();


            Console.ReadKey();
            

        }
    }

    internal class GrandParentsClass
    {
        public string GrandFather { get; internal set; }
    }
}
