using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedFamily.Abstraction
{   
    public abstract class PersonObject
    {
        //An abstract class can contain variables
        private string _personName;
        private int _personAge;
        private bool _hasHead;

        //An abstract class can contain implemented members, like a method
        public void PersonAddress(string newAddress)
        {
            Console.WriteLine("My new address is {0}", newAddress);
        }

        //It can contain unimplemented members, like in the instance of an Interface class
        public abstract string MyOldAddress(string oldAddress);

        //It can also contain Constructors
        protected PersonObject(string personName, int personAge, bool hasHead)
        {
            _personName = personName;
            _personAge = personAge;
            _hasHead = hasHead;
        }

        public virtual int NewAge(int myNewAge)
        {
            Console.WriteLine("my present age is {0}", myNewAge);
            return myNewAge;
        }

    }
}
