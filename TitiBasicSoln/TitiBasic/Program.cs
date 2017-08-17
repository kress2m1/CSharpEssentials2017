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
          Console.WriteLine("Hello");         //This  is introduction to Csharp
          Console.WriteLine("Bryan Divas");

          Console.Write("Hello");  
          Console.Write("Bryan");


          Console.WriteLine();
          string name = "Titi";
            
          Console.WriteLine("My name is " + name);
           
          string welcome = "Hello Bryan Divas";
          Console.WriteLine(welcome);

          Console.WriteLine();
          Console.WriteLine();


            //This is Mathematical function
            //Addition with concartination
          int numOne = 20;
          int numTwo = 30;
          int result = numOne + numTwo;
          Console.WriteLine("20 + 30 = " + result);

          result = numOne * numTwo;
          Console.WriteLine("This result in: " + result);
          result = numTwo - numOne;
          Console.WriteLine(result);
            
          Console.WriteLine();
          double newResult = numTwo / numOne;
          Console.WriteLine(newResult);

          Console.WriteLine();
          newResult = numTwo % numOne;
          Console.WriteLine("30 % 20 = " + newResult);


         // This is if statement
          if (numOne < numTwo)
          {
          Console.WriteLine("numoTwo is > numOne");
           }
           else
          {
          Console.WriteLine("numOne is < numTwo");

          }
           

          Console.ReadKey();














        }


    }
}
