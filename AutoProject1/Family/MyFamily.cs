using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    class MyFamily
    {
        public int age = 23;
        private string name = "rachael";
        protected string adress = "somewhwere";
        private string address;

        public void MyName()
        {
            Console.WriteLine("call my" + name);
        }

        protected void MyAddress()
        {
            Console.WriteLine("My address is"+ address);
        }
    }
}
