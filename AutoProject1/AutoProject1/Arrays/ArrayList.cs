using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoProject1.Arrays
{
    public class ArrayList<_userDetails>
    {
        public ArrayList()
        {
            string[,] _userDetails = new string[5, 2];

            _userDetails[0, 0] = "Kay";
            _userDetails[0, 1] = "1234";
            _userDetails[1, 0] = "Ayo";
            _userDetails[1, 1] = "4567";
            _userDetails[2, 0] = "Titi";
            _userDetails[2, 1] = "2205";
            _userDetails[3, 0] = "Anita";
            _userDetails[3, 1] = "3302";
            _userDetails[4, 0] = "Deji";
            _userDetails[4, 1] = "4405";

        }

        public void CallUserDetails()
        {
            //  foreach (var user in _userDetails)
            {

                //  Console.WriteLine(user);

                {
                    Console.WriteLine("true");
                    // return true;
                }
            }
            Console.WriteLine("false");
            //return false;
        }

        void NewMethod()
        {
            Console.WriteLine(" user");
        }
    }

//    public
//void ListItems()
//{
//    List<string> Menswear = new List<string>();
//    Menswear.Add 
//("Shoes");
//    MensWear.Add 
//("belt");
//    MensWear.Add 
//("Tie");


//    var menswearCount = menswear.Count;
//    Console.Writeline 
//(
//    mensWearCount 
//);

//    foreach (
//    var men in menswear 
//)
//    {
//        if (men.Countains("Shoes"))
//        {
//            Console.WriteLine("shoes are available);
//            break;


//        }
//        else

//        {
//            Console.Writeline("shoes not available");
//        }
//    }

//}
//}
}








