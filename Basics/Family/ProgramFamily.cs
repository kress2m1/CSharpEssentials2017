using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Teen;

namespace Family
{
    public class ProgramFamily : MyFamily
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the main method from the Program Family");

            Teenager teenager = new Teenager();

            teenager.GetDetailsFromBaby();
            Console.WriteLine("Baby's previous address was {0}", teenager.Address);
            teenager.GetMoreDetailsFromBaby();

            teenager.GetSiblingFriendDetails();
            teenager.GiveBabyANewFriend();

            Console.ReadKey();
        }
    }
}
