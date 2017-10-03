using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Coding_Basics.Polymorph
{
    public class DaughterDada : FatherDada
    {
        public override string ThisIsTheFamilyName(string newSurname)
        {
            Console.WriteLine("The new family name is: {0}", newSurname);
            return newSurname;
        }

        public override int TheFamilyFundsAre(int fatherWealthDoubled)
        {
            Console.WriteLine("The family funds have been doubled: {0} ", fatherWealthDoubled);
            return fatherWealthDoubled;
        }

    }
}
