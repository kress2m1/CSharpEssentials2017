using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNewclearFamily
{
   public class Youngstars
    {
        public int Age = 14;
        private string Name = "Bob";
       private int money = 23;
        protected string Address = "Some where";

        private void myName()
        {
            Console.WriteLine("My name is" + Name);
            Console.WriteLine(money * 34);
        }

        public void myAge()
        {
            Console.WriteLine("My age is " + Age + " years old");
            Console.WriteLine(money * 100);
        }

        protected void myAddress()
        {
            Console.WriteLine("My address is" + Address);
        }



    }
}
