using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedFamily.Abstraction
{
    public class KayPerson : PersonObject
    {
        public KayPerson(string personName, int personAge, bool hasHead) : base(personName, personAge, hasHead)
        {
        }

        public override string MyOldAddress(string oldAddress)
        {
            Console.WriteLine("Print My old address {0}", oldAddress);
            return oldAddress;
        }
    }
}
