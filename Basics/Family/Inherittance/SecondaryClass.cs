using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Inherittance
{
    public class SecondaryClass : TetiaryClass
    {
        protected string HomeAddress;
        private int _carNumber;

        public SecondaryClass()
        {
        }

        public SecondaryClass(int carNumber)
        {
            _carNumber = carNumber;
        }

        public SecondaryClass(string homeAddress, int carNumber)
        {
            HomeAddress = homeAddress;
            _carNumber = carNumber;
        }

        public void CallTheSecondaryFamilyName()
        {
            Console.WriteLine("My age is" + FamilyAge);
            DeclareTheTetiaryFamilyJewels();
            Console.WriteLine(FamilyJewels);
        }
    }
}
