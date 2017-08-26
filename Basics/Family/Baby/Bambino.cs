using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.Baby
{
    public class Bambino
    {
        private string BabyName = "Azubike";
        private string LastName = "Edochie";
        public string Address = ": Somewhere";
        protected string BabyFriendsName = "Tope";


        public void DisplayBabyName()
        {
            Console.WriteLine("The baby's name is {0} & her lastname is {1}", BabyName, LastName);
        }

        protected void FriendsOfBaby()
        {
            Console.WriteLine("The baby's best friend is named {0}", BabyFriendsName);
        }
    }
}
