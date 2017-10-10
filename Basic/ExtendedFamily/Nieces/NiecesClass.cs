using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedFamily.Nieces
{
   public class NiecesClass
    {
        //These are our variables
        public string NieceName = "Rachael";
        public string NieceLastName = "Oluwadeji";
       protected string NieceAddress = "C Sharp Class";
        protected string NieceFriendsName = "Titi";

        // These are our methods. You use your variable inside your methods
       public void DisplayNieceName()
       {
           Console.WriteLine("My name is " + NieceName);
            //the example below is called interpolation
            // Console.WriteLine("My Name is {0} and I live at {1}", NieceName, NieceAddress);
            Console.WriteLine("My Name is {0}", NieceName);
       }

       protected void FriendsOfNiece()
       {
           Console.WriteLine("My niece's friend is named: " + NieceFriendsName);
       }

       private void AddressofNiece()
       {
           Console.WriteLine("My niece lives at {0}", NieceAddress);

       }

    }
}
