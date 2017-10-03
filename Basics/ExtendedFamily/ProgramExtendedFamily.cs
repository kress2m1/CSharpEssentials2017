using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendedFamily.Abstraction;
using ExtendedFamily.ExceptionHandler;

namespace ExtendedFamily
{
    class ProgramExtendedFamily
    {
        static void Main(string[] args)
        {
            //var kayPerson = new KayPerson("Kay", 55, true);
            //kayPerson.MyOldAddress("Somewhere");
            //kayPerson.PersonAddress("Here");

            //PersonObject po = new KayPerson("Anita", 24, true);
            //po.MyOldAddress("Harrods");
            //po.PersonAddress("London");

            //PersonObject tp = new TitiPerson("Titi", 38, true);
            //tp.NewAge(38);

            Console.WriteLine("Please enter first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 2nd number");
            int b = int.Parse(Console.ReadLine());
            ExceptionManager em = new ExceptionManager();
            em.DivideMe(a, b);

            Console.ReadKey();
        }
    }
}
