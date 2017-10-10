using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Interfaces;

namespace Family.ToyotaCar
{
    public class ToyotaLexus : ICars
    {
        public void Accelerate()
        {
            Console.WriteLine("The car can accelerate");
        }

        public void Drive()
        {
            Console.WriteLine("The car is drivable");
        }

        public void Stop()
        {
            Console.WriteLine("The car can stop");
        }

        public void TootHorn()
        {
            Console.WriteLine("I like beeping the horn");
        }

        public int HaveTyres(int numTyres)
        {
            Console.WriteLine("You need {0} tyres for a Lexus", numTyres);
            return numTyres;
        }
    }
}
