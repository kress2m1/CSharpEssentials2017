using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProject1
{
   public class Cat
    {
         int numberofeyes = 2;
         int numberoflegs = 4;
         int numberofears = 2;
         int numberoftail = 1;
         int numberofmouth = 1;


        //VariableDeclarationStatement of object


        //Cat can eat
        public void eat()
        {
            Console.WriteLine("I can eat");
        }

        public void mew()
        {
            Console.WriteLine("I can mew");
        }

        public void run()
        {
            Console.WriteLine("I can run");
        }
        public void drink()
        {
            Console.WriteLine("I can drink");
        }
    }
}
