using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendedFamilies.Nieces;

namespace ExtendedFamilies.Cousins
{
   public class CousinsClass : NiecesClass
   {
       private string CousinsName = "Tee";
       private string CousinslastName = "Taye";
       public string CousinsAddress = "London";
       protected string CousinsFriendsName = "Kayode";

       public void ChangeNiecefriendsName()
       {
           Console.WriteLine("My nieces friends name is{0}", NieceFriendsName);

       }
   }
}
