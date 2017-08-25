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
            var NewTeenAddress = "Yonder";
            Console.WriteLine("Teenager now lives at {0}", NewTeenAddress);
        }

        public void GetSomeMoreInfoAboutTeen()
        {
            TeenFriend();
        }
    }
}
