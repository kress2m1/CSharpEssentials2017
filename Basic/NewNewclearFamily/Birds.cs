using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNewclearFamily
{
    public class Birds
    {
        private int _numOfeyes = 2;
        private string _nameOfBird = "Swallow";
        private int NumOfLegs = 2;


        //This is a getter for NumOfEyes
        public int GetNumOfEyes()
        {
            return _numOfeyes;
        }

        //this is a setter for NumOfEyes
        public void SetNumOfEyes(int setNumOfEyes)
        {
            this._numOfeyes = setNumOfEyes;
        }

        //this is another getter for NameOfBird
        public string GetNameOfBird()
        {
            return _nameOfBird;
        }

        //this is another setter for NameOfBird
        public void SetNameOfBird(string setNameOfBird)
        {
            this._nameOfBird = setNameOfBird;
        }
    }
}
