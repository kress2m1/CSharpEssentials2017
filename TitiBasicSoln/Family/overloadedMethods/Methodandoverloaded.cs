using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.overloadedMethods
{
    public class Methodandoverloaded
    {
        public int one = 3;
        public int Two = 4;
        public int Three;
        public void Additionmethod()

        {
            Three = one + Two;
            Console.WriteLine("Addition of one and Two is " + Three ); 
        }

    }
}
