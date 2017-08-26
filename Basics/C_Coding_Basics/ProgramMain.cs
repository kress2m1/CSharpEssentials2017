﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Coding_Basics.Humans;
using ExtendedFamily.Cousins;
using ExtendedFamily.GrandParents;
using ExtendedFamily.Nieces;
using Family;


namespace C_Coding_Basics
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            
            // Class --> Object = New Instance --> Constructor
            //Dog husky = new Dog();
            //Console.WriteLine("This is a Husky");
            //husky.Bark();

            //Console.WriteLine();
            //Console.WriteLine("This is a Hush Puppy");
            //Dog hushPuppy = new Dog();
            //hushPuppy.Bark();
            //hushPuppy.Drink();
            //hushPuppy.Eat();

            //Human humansTeen = new Human();
            //humansTeen.PullDetailsFromTeenager();

            NiecesClass niece = new NiecesClass();
            niece.DisplayNieceName();

            CousinsClass cousinsClass = new CousinsClass();
            cousinsClass.DisplayNieceName();
            cousinsClass.CallNieceFriendsName();
            cousinsClass.CallDetailsForNiece();


            Console.ReadKey();
        }
    }
}
