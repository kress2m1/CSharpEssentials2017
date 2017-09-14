using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendedFamily.Nieces;

namespace ExtendedFamily.Cousins
{
    public class CousinsClass : NiecesClass
    {
        private string _cousinName = "Lanre";
        private string _cousinLastName = "Ayo";
        public string CousinAddress = "Online";
        protected string CousinFriendsName = "Kayode";

        public void CallNieceFriendsName()
        {
            Console.WriteLine("My nieces friends name is {0}", NieceFriendsName);
        }

        public void CallDetailsForNiece()
        {
            //var bambino = new Bambino { Address = "HereOrThere" };
            Console.WriteLine("My niece lives at {0}", NieceAddress);
            Console.WriteLine("And her name is {0}", NieceName);
            var newNieceName = "Bola";
            Console.WriteLine("Her name is now {0}", newNieceName);
        }

        //public void CallDetailsForNiece()
        //{
        //    //var bambino = new Bambino { Address = "HereOrThere" };
        //    NiecesClass nieces = new NiecesClass();
        //    Console.WriteLine("My niece lives at {0}", NieceAddress);
        //    Console.WriteLine("And her name is {0}", NieceName);
        //    string newNieceName = nieces.NieceName;
        //    newNieceName = "Bola";
        //    Console.WriteLine("Her name is now {0}", newNieceName);
        //}
    }
}
