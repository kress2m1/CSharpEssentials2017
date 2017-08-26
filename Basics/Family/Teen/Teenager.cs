using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Family.Baby;

namespace Family.Teen
{
    public class Teenager : Bambino
    {

        private string TeenName = "Tunji";
        public int TeenAge = 18;
        protected string TeenAddress = "Over here";

        public void GetDetailsFromBaby()
        {
            var bambino = new Bambino {Address = "A New Place"};
            bambino.DisplayBabyName();
            Console.WriteLine("The baby now lives at: " + bambino.Address);
        }

        public void GetMoreDetailsFromBaby()
        {
            var bambino = new Bambino {Address = "HereOrThere"};
            Console.WriteLine("Baby has now moved {0}", bambino.Address);
        }

        public void GetSiblingFriendDetails()
        {
            var babyFriendsName = "Wale";
            Console.WriteLine("My sibling's best friend is now {0}", babyFriendsName);
        }

        public void GiveBabyANewFriend()
        {
            var newFriendsName = "Hamza";
            Console.WriteLine("My sibling has a new friend called {0}", newFriendsName);
        }

        protected void TeenFriend()
        {
            Console.WriteLine("My teen hangs out with his friends");
        }

        private void TeenGrades()
        {
            Console.WriteLine("I can't find my teen's grades anywhere!!");
        }
    }
}
