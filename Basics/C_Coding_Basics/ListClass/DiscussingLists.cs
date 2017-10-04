using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Coding_Basics.ListClass
{
    public class DiscussingLists
    {
        private string[,] _userDetails;

        public DiscussingLists()
        {
            _userDetails = new string[3,2];
            _userDetails[0, 0] = "Kay";
            _userDetails[0, 1] = "1234";
            _userDetails[1, 0] = "Ayo";
            _userDetails[1, 1] = "4567";
            _userDetails[2, 0] = "titi";
            _userDetails[2, 1] = "2202";
        }

        public bool CallUserDetails(string userPassword)
        {
            foreach (var user in _userDetails)
            {
                //Console.WriteLine(user);
                if (user.Contains(userPassword))
                {
                    //Console.WriteLine("true");
                    return true;
                }
            }
            //Console.WriteLine("false");
            return false;
        }

        public void ListItems()
        {
            List<string> mensWear = new List<string>();
            mensWear.Add("Shoes");
            mensWear.Add("belt");
            mensWear.Add("Tie");
            mensWear.Add("CUFFLINKS");
            mensWear.Add("Bata"); //

            var mensWearCount = mensWear.Count;
            Console.WriteLine(mensWearCount);

            foreach (var men in mensWear)
            {
                if (men.Contains("Shoess"))
                {
                    Console.WriteLine("Shoes are availble");
                    break;
                }
                else if (men.Contains("Tieses"))
                {
                    Console.WriteLine("Tie is available");
                    break;
                }
                else
                {
                    Console.WriteLine("Product not available");
                    break;
                }
            }
        }
    }
}
