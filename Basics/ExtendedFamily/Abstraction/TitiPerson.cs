using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedFamily.Abstraction
{
    public class TitiPerson : PersonObject
    {
        public TitiPerson(string personName, int personAge, bool hasHead) : base(personName, personAge, hasHead)
        {
        }

        public override string MyOldAddress(string oldAddress)
        {
            Console.WriteLine("Print me");
            return oldAddress;
        }

        public override int NewAge(int myFootballAge)
        {
            Console.WriteLine("My new age is {0}", (myFootballAge / 2));
            return myFootballAge;
        }
    }
}
