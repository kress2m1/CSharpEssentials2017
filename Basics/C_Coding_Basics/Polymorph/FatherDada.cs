using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Coding_Basics.Polymorph
{
    public class FatherDada
    {
        //public void PolyMe(int oneInt)
        //{
        //    Console.WriteLine("Printing int {0}", oneInt);
        //}

        //public void PolyMe(string stringOne)
        //{
        //    Console.WriteLine("Printing string {0}", stringOne);
        //}

        //public void PolyMe(double doubleOne)
        //{
        //    Console.WriteLine("Printing double {0}", doubleOne);
        //}

        public virtual string ThisIsTheFamilyName(string originalName)
        {
            Console.WriteLine("The family name is: {0}", originalName);
            return originalName;
        }

        public virtual int TheFamilyFundsAre(int fatherWealth)
        {
            Console.WriteLine("The family funds are worth: {0} ", fatherWealth);
            return fatherWealth;
        }
    }
}
