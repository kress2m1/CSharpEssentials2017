using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Teen;

namespace C_Coding_Basics.Humans
{
    public class Human : Teenager
    {
        public void PullDetailsFromTeenager()
        {
            var newTeenAddress = "Yonder";
            Console.WriteLine("Teenager now lives at {0}", newTeenAddress);
        }

        public void GetSomeMoreInfoAboutTeen()
        {
            TeenFriend();
        }
    }
}
