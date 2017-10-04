using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProject1.Arrays
{
    public class ArrayClass
    {
        private string Biology;
        private string Physics;
        private int teacher;
        private int course;

        public string Maths { get; private set; }

        // Array is a data type [int,string, long, float] arrayname that refelect variables insised it predators lion,jaguaretc; always put array in a method
        public void AgeofPatients()
        {
            double[] ageofPatients = new double[4];
            ageofPatients[0] = 30;
            ageofPatients[1] = 25;
            ageofPatients[2] = 26;
            ageofPatients[3] = 40;

            Console.WriteLine(ageofPatients [0]);
            Console.WriteLine(ageofPatients [1]);
            Console.WriteLine(ageofPatients [2]);
            Console.WriteLine(ageofPatients [3]);
        }

        public void TeacherName()
        {
            string[] teachersName = {"Olu", "Tolu", "Ben", "Richie"};
            for (int teacher = 0; teacher < teachersName.Length; teacher++)
            {

                Console.WriteLine("The names of the teachers are: {0}", teachersName[teacher]);
            }
            Console.WriteLine("..........");
            Array.Sort(teachersName);
            Console.WriteLine("teacherName");
        }

        public void CourseNames()
        {
            string[] courseNames = new[] {"Maths", "Biology", "Physics"};
            foreach (var Course in courseNames)

            
            {
                if (!course.Equals("Maths")) continue;
                Console.WriteLine("The course names are: {0}", course);
                break;
            }
        }


    


}
}
