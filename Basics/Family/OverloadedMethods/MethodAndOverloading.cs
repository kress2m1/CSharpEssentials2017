using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family.OverloadedMethods
{
    public class MethodAndOverloading
    {
        public int FirstNum = 2;
        public int SecondNum = 3;
        public int ThirdNum;
        public int SixthNum;
        public int NinthNum;

        public MethodAndOverloading(int thirdNum, int sixthNum, int ninthNum)
        {
            ThirdNum = thirdNum;
            SixthNum = sixthNum;
            NinthNum = ninthNum;
        }

        public void AdditionMethod()
        {
            ThirdNum = FirstNum + SecondNum;
            Console.WriteLine("addition of one and two is: " + ThirdNum);
        }

        public int AdditionMethod(int fourthNum, int fifthNum)
        {
            SixthNum = fourthNum * fifthNum;
            Console.WriteLine("{0} * {1} = {2}", fourthNum, fifthNum, SixthNum);
            return SixthNum;
        }

        public int AdditionMethod(int seventhNum, int eighthNum, int tenthNum)
        {
            NinthNum = seventhNum + eighthNum + eighthNum + tenthNum;
            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", seventhNum, eighthNum, eighthNum, tenthNum, NinthNum);
            return NinthNum;
        }
    }
}
