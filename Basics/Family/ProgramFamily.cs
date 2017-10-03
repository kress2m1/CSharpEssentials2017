using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Family.Inherittance;
using Family.Interfaces;
using Family.OverloadedMethods;
using Family.Teen;
using Family.ToyotaCar;

namespace Family
{
    public class ProgramFamily : MyFamily
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the main method from the Program Family");

            //Teenager teenager = new Teenager();

            //teenager.GetDetailsFromBaby();
            //Console.WriteLine("Baby's previous address was {0}", teenager.Address);
            //teenager.GetMoreDetailsFromBaby();

            //teenager.GetSiblingFriendDetails();
            ////teenager.GiveBabyANewFriend();

            //MethodAndOverloading methodAndOverloading = new MethodAndOverloading(11, 22, 33);
            //methodAndOverloading.AdditionMethod();
            //Console.WriteLine("---------------");
            //methodAndOverloading.AdditionMethod(44, 55);
            //methodAndOverloading.AdditionMethod(100, 23);
            //methodAndOverloading.AdditionMethod(25, 78);
            //methodAndOverloading.AdditionMethod(44, 28);
            //Console.WriteLine("---------------");
            //methodAndOverloading.AdditionMethod(14, 21, 10);

            //Console.WriteLine("---------------");
            //Birds birds = new Birds();
            //Console.WriteLine(birds.GetNameOfBird());
            //Console.WriteLine(birds.GetNumOfEyes());
           
            //birds.SetNameOfBird("Eagle");
            //birds.SetNumOfEyes(4);
            //Console.WriteLine(birds.GetNameOfBird());
            //Console.WriteLine(birds.GetNumOfEyes());
            
            //PrimaryClass primaryClass = new PrimaryClass();
            //primaryClass.DeclarePrimaryClass();

            var toyotaLexus = new ToyotaLexus();
            toyotaLexus.Accelerate();

            ICars toyota = new ToyotaLexus();
            toyota.Drive();
            toyota.Stop();
            toyota.TootHorn();
            
            IVehicle toyotaV = new ToyotaLexus();
            toyotaV.HaveTyres(5);

            Console.ReadKey();
        }
    }
}
