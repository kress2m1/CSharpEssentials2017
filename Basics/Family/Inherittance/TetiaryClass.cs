using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Inherittance
{
    public class TetiaryClass
    {
        protected string FamilyJewels;
        protected string FamilyName;
        protected double FamilyTrustFundAmount;
        private bool _familyAccount = true;
        public int FamilyAge = 55;  

        public void DeclareTheTetiaryFamilyJewels()
        {
            Console.WriteLine("The family jewels are: {0}", FamilyJewels);
        }

        public void DeclareTheTetiaryFamilyName()
        {
            Console.WriteLine("The family name is: {0}", FamilyName);
            Console.WriteLine("Does the family account exist?: {0}", _familyAccount);
        }

    }
}
