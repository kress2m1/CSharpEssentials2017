using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ExtendedFamily.Nieces;

namespace ExtendedFamily.Cousins
{
   public class CousinsClass : NiecesClass
    {
        private string CousinName = "Lanre";
        private string CousinLastName = "Ayo";
        public string CousinAddress = "Online";
        protected string CousinFriendsName = "Kayode";

      // public void ChangeNieceFriendsName()
      public void callAddressForNiece()
       {
            //Console.WriteLine("My nieces friends name is {0}", NieceFriendsName);
            Console.WriteLine("And her name is {0}", NieceName);
       }

       public void CallNieceFriendsName()
       {
           Console.WriteLine("My nieces friends name is {0}", NieceFriendsName);
       }

       public void CallDetailsForNiece()
       {
            //NiecesClass nieces = new NiecesClass();
            //// string newnieceNames = nieces.NieceName;
            //Console.WriteLine("My niece now lives at {0}", NieceAddress);
            //Console.WriteLine("And her name is {0}", NieceName);
            //string newnieceNames = nieces.NieceName;
            //newnieceNames = "Bola";
            //Console.WriteLine("Her name is now {0}", newnieceNames);

            //THIS IS THE CODE AFTER IT HAS BEEN REFACTORED
          //  NiecesClass nieces = new NiecesClass(); // we get rid of this bcos it is redundant
          // string newnieceNames = nieces.NieceName;
            Console.WriteLine("My niece now lives at {0}", NieceAddress);
           Console.WriteLine("And her name is {0}", NieceName);
           var newnieceNames = "Bola";
           Console.WriteLine("Her name is now {0}", newnieceNames);


       }

    }
}
