using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MainMethod.ANIMALS;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st create a CLASS  -> object = New Instance -> Constructor
            
            BIRDS Kpekpeye = new BIRDS();
            Console.WriteLine("this a KPEKPEYE");
            Kpekpeye.RUN();
            Console.WriteLine();
            Console.WriteLine("This is a TOLOTOLO");
            BIRDS Tolotolo = new BIRDS();
            Tolotolo.MakeAnnoyingNoises();
            Tolotolo.SING();
            Tolotolo.FLY();

            Console.ReadKey();

        }
    }
}
