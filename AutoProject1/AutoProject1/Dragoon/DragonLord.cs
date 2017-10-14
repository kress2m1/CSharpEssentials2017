using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProject1.Dragoon
{
    class DragonLord
    {
       // CodeVariableDeclarationStatement of object
        private int _Eyes;
        private int _Legs;
        private int _Ears;
        private int _Tail;
        private int _Mouth;
        private string _Breathes;

        public DragonLord(int eyes, int legs, int tail, int mouth, string breathes)
        {
            _Eyes = eyes;
            _Legs = legs;
            _Ears = _Ears;
            _Tail = tail;
            _Mouth = mouth;
            _Breathes = breathes;
        }

        public DragonLord(int tail, int mouth, string breathe)
        {
            _Tail = tail;
            _Mouth = mouth;
            _Breathes = breathe;
         
        }

        public void DragonLord()
        //Constructor

        public void AddMethod()
        {
            var numOne = 22;
            var numTwo = 33;
            var result = numOne + numTwo;
            Console.WriteLine("The result of numOne + numTwo is:" + result);
            Console.WriteLine("This is the first method");

        }
        //Upgrade: variable in this instance are not hardcoded and but could be improved for the result to be used
        public float AdditionMethod (float numeOne, int numTwo , int numThree)
        {
            float result = numeOne + numTwo;
            Console.WriteLine("The result of numOne + numTwo is:" + result);
            Console.WriteLine("This is the second method");
            return result;
        }
        //best : This return the output, but its not visible as the Upgrade, its  encapsulated in a manner, and cant be seen
        public int AdditionMethod(int numOne , int numTwo)
        {
            int result = numOne + numTwo;
            Console.WriteLine("This is the third method");
            return result;
        }

    }
}
