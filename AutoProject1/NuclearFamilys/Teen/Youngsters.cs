using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuclearFamilys.Teen
{
    class Youngsters
    {
        public int Age = 14;
        public string Name = "Bob";
        protected string Address = "OYO";

        public void MyName()
        {
            Console.WriteLine("My name is" + Name);
        }

        public void MyAge()
        {
            Console.WriteLine("My age is" + Age);
        }

        protected void myAddress()
        {
            Console.WriteLine("My address is" + Address);
        }
    }
}

