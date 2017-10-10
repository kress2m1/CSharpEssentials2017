using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNewclearFamily.OverloadedMethods
{
    public class MethodAndOverloading
    {
        public int FirstNum = 2;
        public int SecondNum = 3;
        public int ThirdNum;
        public int SixthNum;
        public int NinthNum;
    
        public void AdditionMethod()
        {
            ThirdNum = FirstNum + SecondNum;
            Console.WriteLine("Addition of one and two is: " + ThirdNum);
        }

        public int AdditionMethod(int FourthNum, int FifthNum) // the four and five here is variable is not a number
        {
            //SixthNum = FourthNum + FifthNum + FourthNum;
            ////Console.WriteLine("44 + 55 + 44: " + SixthNum);
            //Console.WriteLine("{0} + {1} + {2} = {3}", FourthNum, FifthNum, FourthNum, SixthNum);
            //return SixthNum;

            SixthNum = FourthNum * FifthNum;
            Console.WriteLine("{0} * {1} - {2}", FourthNum, FifthNum, SixthNum);
            return SixthNum;
        }

        public int AdditionMethod(int SeventhNum, int EighthNum, int TenthNum)
        {
            NinthNum = SeventhNum + EighthNum + EighthNum + TenthNum;
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", SeventhNum, EighthNum, EighthNum, TenthNum, NinthNum);
            return NinthNum;
        }

        //public void AdditionMethod(int seventhNum, int fifthNum)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
