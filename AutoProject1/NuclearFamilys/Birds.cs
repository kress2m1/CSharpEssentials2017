using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuclearFamilys
{
    public class Birds
    {
        private int NumOfEyes = 2;
        private string NameOfBird = "Swallow";
        private int NumOfLegs = 2;

        public int getNumOfEyes()
        {
            return NumOfEyes;
        }

        public void setNumOfEyes(int setNumOfEyes)
        {
            this.NumOfEyes = setNumOfEyes;
        }


        public string getNameOfBird()
        {
            return NameOfBird;
        }

        public void setNameOfBird(string setNameOfBird)
        {
            this.NameOfBird = setNameOfBird;
        }

        public int getNumOfLegs()
        {
            return NumOfLegs;

        }

        public void setNumOfLegs(int setNumOfLegs)
        {
            this.NumOfLegs = setNumOfLegs;
        }
    }
}

