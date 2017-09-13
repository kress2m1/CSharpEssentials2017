using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewNewclearFamily;
using NewNewclearFamily;

namespace New_C_Coding_Class
{
   public class Dog : Youngstars
    {
        //variable of object dog. we have data type, variable name and value
        public 
        int numberOfEyes = 2;
        int numberOfLegs = 4;
        int numberofEars = 2;
        int numberOfTail = 1;
        int numberOfMouth = 1;

        //methods of object dog
        //Our dog can eat. these are the charcteristics of our dog
        public void eat()
        {
            Console.WriteLine("I can eat");
        }

        public void bark()

        {
            Console.WriteLine("I can bark");
        }

        public void run()
        {
            Console.WriteLine("I can run");
        }

        public void drink()
        {
            Console.WriteLine("I can drink");
        }

        //Youngstars youngstars = new Youngstars();
       // Youngstars


    }
}
