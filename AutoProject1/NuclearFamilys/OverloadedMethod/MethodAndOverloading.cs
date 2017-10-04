using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace NuclearFamilys.OverloadedMethod
{
    public class MethodAndOverloading
    {
        //public int One = 2;
        //public int Two = 3;
        //public int Three;

        public int FirstNum = 2;
        public int SecondNum = 3;
        public int ThirdNum;
        public int SixthNum;
        public int NithNum;

        public void AdditionMethod()
        {
            //int Three = One + Two;
            //Console.WriteLine("addition of one and two is:" + Three);
            ThirdNum = FirstNum + SecondNum;
            Console.WriteLine("addition of firstnum + secondnum is", +ThirdNum);
        }

        public int AdditionMethod(int FourtNum, int FiftNum)
        {
            int FourthNum = 0;
            var SixthNum = FourthNum + FiftNum + FourtNum;
            Console.WriteLine("44 + 55 +44:", + SixthNum);
            return SixthNum;
        }

        public int Additionmethod(int Seventh, int EightNum, int TenthNum)
        {
            //int TenthNum = 14;
            int SeventhNum = 21;
            int EleventhNum = 10;
            var NinthNum = SeventhNum + EightNum + TenthNum;
            return NinthNum;
            {


            }
        }
    }
}
