using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class MyFamily
    {
        public int Age = 23;
        private string Name = "Andre";
        private int Money = 23;
        protected string Address = "some where";

        public void MyAge()
        {
            Console.WriteLine("I am " + Age + " years old");
            Console.WriteLine(Money * 100);
        }

        protected void MyAddress()
        {
            Console.WriteLine("I live at" + Address);
        }

        private void MyName()
        {
            Console.WriteLine("my name is" + Name);
            Console.WriteLine(Money * 34);
        }


    }
}
