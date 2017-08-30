using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtenededFamily.Nieces
{
   public class NiecesClass
    {
        public string NieceName = "Tobi";
        public string NieceLastName = "Gabriel";
        private string  NieceAddress  =   "York";
        protected string NieceFriendsName = "Toba";

       public void DisplayNieceName()
       {
          Console.WriteLine("My name is"+ NieceName);
          //Console.WriteLine("My name is{0} and I live at {1}", NieceName,NieceAddress);
          Console.WriteLine("My name is{0}", NieceName);
        }

       protected void friendofNiece()
       {
           Console.WriteLine("My niece's friend is", NieceFriendsName);

       }

       private void NiecesAddress()
       {
           Console.WriteLine("My niece lives at {0}", NieceAddress);
       }
    }
}
