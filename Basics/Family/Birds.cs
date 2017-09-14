using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class Birds
    {
        private int _numOfeyes = 2;
        private string _nameOfBird = "Swallow";
        private int _numOfLegs = 2;

        private int _legs = 3;
        public string Nose { get; set; } = "Test";

        //This is the getter for NumOfEyes
        public int GetNumOfEyes()
        {
            return _numOfeyes;
        }

        //this is the setter for NumOfEyes
        public void SetNumOfEyes(int setNumOfEyes)
        {
            this._numOfeyes = setNumOfEyes;
        }

        //this is the getter for NameOfBird
        public string GetNameOfBird()
        {
            return _nameOfBird;
        }

        //this is the setter for NameOfBird
        public void SetNameOfBird(string setNameOfBird)
        {
            this._nameOfBird = setNameOfBird;
        }
    }
}
