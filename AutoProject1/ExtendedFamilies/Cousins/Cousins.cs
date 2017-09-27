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
       public string CousinsName = "Tee";
       private string CousinslastName = "Taye";
       public string CousinsAddress = "London";
       protected string CousinsFriendsName = "Kayode";

       public void CallNiecefriendsName()
       {
           Console.WriteLine("My nieces friends name is{0}", NieceFriendsName);

       }

       public void CallDetailsForNiece()
       {
            NiecesClass nieces =new NiecesClass();
           string newNiecesName = nieces.NieceName;
           Console.WriteLine("My niece lives at{0}", NieceAddress);
           Console.WriteLine("And her name is {0}", NieceName);
           newNiecesName = "Bola";
           Console.WriteLine("My name is now {0}", newNiecesName);

       }
   }
}
