using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNewclearFamily.Baby
{
   public class newBambino
    {
        public int Age = 14;
        public string Name = "Jane";
        public string Address = "Some where";
        private string BabyName = "Azubike";
        private string LastName = "Edochie";
        protected string BabyFriendsName = "Tope";

        public void DsiplayBabyName()
        {
            Console.WriteLine("The baby's name is {0} & her lastname is {1}", BabyName, LastName);
          
        }

       protected void FriendsOfBabay()
       {
           Console.WriteLine("The baby's best friend is named {0}" , BabyFriendsName);

       }

    }
}
