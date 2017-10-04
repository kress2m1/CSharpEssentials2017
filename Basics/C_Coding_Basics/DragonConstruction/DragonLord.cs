using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Coding_Basics.DragonConstruction
{
    public class DragonLord
    {
        //variables of object drogon
        private int _eyes;
        private int _legs;
        private int _ears;
        private int _tail;
        private int _mouth;
        private string _breathes;
        

        public DragonLord(int eyes, int legs, int ears, int tail, int mouth, string breathes)
        {
            _eyes = eyes;
            _legs = legs;
            _ears = ears;
            _tail = tail;
            _mouth = mouth;
            _breathes = breathes;
        }

        public DragonLord(int tail, int mouth, string breathes)
        {
            _tail = tail;
            _mouth = mouth;
            _breathes = breathes;
        }

        public void BlackDragon()
        {
            Console.WriteLine("black dragon features");
            Console.WriteLine("BD has " + _tail + " tails and " + _mouth + " mouth and " + _breathes);
        }

        public void BludDragon()
        {
            Console.WriteLine("BD has " + _eyes + "eyes" + _legs + " legs" + _ears + " ears" + _tail + " tails" + _mouth + " mouth " + _breathes);
        }

        public void AddMethod()
        {
            var numOne = 22;
            var numTwo = 33;
            var result = numOne + numTwo;
            Console.WriteLine("The result of numOne + numTwo is: " + result);
            Console.WriteLine("This is the first method");
        }

        //UPGRADE: variables in this instance are not hardcoded and but could be improved, for the result to be used wherever needed
        public void AddMethod(float numOne, float numTwo)
        {
            float result = numTwo + numOne;
            Console.WriteLine("The result of numOne + numTwo is: " + result);
            Console.WriteLine("This is the second method");
        }

        //BEST: This returns the output, but it's not visible as the UPGRADE, it's encapsulated in a manner, and can be used wherever needed
        public int AddMethod(int numOne, int numTwo)
        {
            int result = numOne + numTwo;
            Console.WriteLine("This is the thiord method");
            return result;
        }


    }
}
