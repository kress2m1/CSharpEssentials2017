using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedFamilies.Nieces
{
   public class NiecesClass
    {
        //These are certain variables
       public string NieceName = "Rachael";
       private string NieceLastName = "Oluwadeji";
       public string NieceAddress = "Csharp class";
       protected string NieceFriendsName = "Titi";


        //These are methods
       public void DisplayNieceName()
       {
           Console.WriteLine("My name is" + NieceName);
            // Example of interpolation
            //  Console.WriteLine("My name is{0}", Niecename,NieceAddress);
           Console.WriteLine("My name is{0}", NieceName);
            }

       protected void FriendsOfNieces()
       {
           Console.WriteLine(" My nieces friend is named" + NieceFriendsName);
       }

       private void AddressofNiece()
       {
           Console.WriteLine("My niece lives at {0}", NieceAddress);
       }
    }
}
