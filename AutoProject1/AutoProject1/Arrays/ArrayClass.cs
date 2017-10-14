using System;

namespace AutoProject1.Arrays
{
    public class ArrayClass
    {
        public string Biology;
        public string Physics;
        public int teacher;
        public int course;

        public string Maths { get; private set; }

        // Array is a data type [int,string, long, float] arrayname that refelect variables insised it predators lion,jaguaretc; always put array in a method
        public void AgeofPatients()
        {
            double[] ageofPatients = new double[4];
            ageofPatients[0] = 30;
            ageofPatients[1] = 25;
            ageofPatients[2] = 26;
            ageofPatients[3] = 40;

            Console.WriteLine(ageofPatients[0]);
            Console.WriteLine(ageofPatients[1]);
            Console.WriteLine(ageofPatients[2]);
            Console.WriteLine(ageofPatients[3]);
        }

        public void TeacherName()
        {
            string[] teachersName = {"Olu", "Tolu", "Ben", "Richie"};
            foreach (var teacher in teachersName)
            {
                Console.WriteLine("The names of the teachers are: {0}", teacher);
            }
            Console.WriteLine("..........");
            Array.Sort(teachersName);
            foreach (var teacher in teachersName)
            {
                Console.WriteLine("The names of the teachers are: {0}", teacher);
            }
        }

        public void CourseNames()
        {
            string[] courseNames = { "Maths", "Biology", "Physics" };
            foreach (var course in courseNames)


            {
                if (course.Equals("Maths"))
                {
                    Console.WriteLine("The courses available include{0}", course);
                    break;
                }
                if (!course.Equals("Physics")) continue;
                Console.WriteLine("The course names are: {0}", course);
                break;
            }

            Array.Reverse(courseNames);
            foreach (var course in courseNames)
            {
                Console.WriteLine("The list of courses available in reverse: {0}", course);
            }
            {
                
            }
        }





    }
}
