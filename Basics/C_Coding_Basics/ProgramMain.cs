using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Coding_Basics.ArraysClass;
using C_Coding_Basics.DragonConstruction;
using C_Coding_Basics.Humans;
using C_Coding_Basics.ListClass;
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

            //NiecesClass niece = new NiecesClass();
            //niece.DisplayNieceName();

            //CousinsClass cousinsClass = new CousinsClass();
            //cousinsClass.DisplayNieceName();
            //cousinsClass.CallNieceFriendsName();
            //cousinsClass.CallDetailsForNiece();

            //DiscussingArrays discussingArrays = new DiscussingArrays();
            //discussingArrays.AgeOfStudents();
            //discussingArrays.TeacherName();
            //discussingArrays.CourseNames();

            //Console.WriteLine("Please enter a password");
            //string userPassword = Console.ReadLine();

            //DiscussingLists discussingLists = new DiscussingLists();
            //discussingLists.CallUserDetails(userPassword);
            //discussingLists.ListItems();

            DragonLord dragon = new DragonLord(4, 3, "breathes fire");
            dragon.BlackDragon();
            
            DragonLord droDragonLord = new DragonLord(2, 3, 4, 2, 2, "nonsense dragon");
            droDragonLord.BludDragon();

            


            Console.ReadKey();
        }
    }
}
