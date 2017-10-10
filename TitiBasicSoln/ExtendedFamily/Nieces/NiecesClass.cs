using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedFamily.Nieces
{
  public  class NiecesClass
    {
        // These are our variables
         public string NieceName = "Tai";
         public string NieceLastName = "michael";
         private string NieceAddress = "RFH";
         protected string NieceFriendsName = "Sammy";

        //These are our Methods
      public void DisplayNieceName()
      {
          Console.WriteLine("My name is" + NieceName);
            //the example below is interpollation
            Console.WriteLine("My name is {0}" , NieceName);

      }

      protected void FriendsOfNiece()
      {
          Console.WriteLine("My niece's friend is named: " + NieceFriendsName);
        
      }

      private void AddressOfNiece()
      {
          Console.WriteLine("My niece live at {0}" + NieceAddress);
      }
    }
}
