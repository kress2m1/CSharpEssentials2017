using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Inherittance
{
    public class PrimaryClass : SecondaryClass
    {         
        public void DeclarePrimaryClass()
        {
            CallTheSecondaryFamilyName();
            DeclareTheTetiaryFamilyJewels();
            Console.WriteLine(FamilyName);
            DeclareTheTetiaryFamilyName();
        }  
    }
}
