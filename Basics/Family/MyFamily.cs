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
        private string _name = "Andre";
        private int _money = 23;
        protected string Address = "some where";

        public void MyAge()
        {
            Console.WriteLine("I am " + Age + " years old");
            Console.WriteLine(_money * 100);
        }

        protected void MyAddress()
        {
            Console.WriteLine("I live at" + Address);
        }

        private void MyName()
        {
            Console.WriteLine("my name is" + _name);
            Console.WriteLine(_money * 34);
        }
    }
}
