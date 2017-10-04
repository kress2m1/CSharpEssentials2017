using System;

namespace C_Coding_Basics.ArraysClass
{
    public class DiscussingArrays
    {
        //datatype[] arrayName;

        public void AgeOfStudents()
        {
            double[] ageOfStudents = new double[3];
            ageOfStudents[0] = 23;
            ageOfStudents[1] = 22;
            ageOfStudents[2] = 25;

            Console.WriteLine(ageOfStudents[0]);
            Console.WriteLine(ageOfStudents[1]);
            Console.WriteLine(ageOfStudents[2]);
        }

        public void TeacherName()
        {
            string[] teacherName = {"Ayo", "Anita", "Kay", "Deen", "Lanre"};
            foreach (var teacher in teacherName)
            {
                Console.WriteLine("The names of the teachers are: {0} ", teacher);
            }
            Console.WriteLine("-----------");
            Array.Sort(teacherName);
            foreach (var teacher in teacherName)
            {
                Console.WriteLine("The names of the teachers are: {0} ", teacher);
            }
        }

        public void CourseNames()
        {
            string[] courseNames = {"Java", "C#", "C++"};
            foreach (var course in courseNames)
            {
                if (!course.Equals("C#")) continue;
                Console.WriteLine("The courses available include: {0}", course);
                break;

                //if (course.Equals("C#"))
                //{
                //    Console.WriteLine("The courses available include: {0}", course);
                //    break;
                //}
            }

            Array.Reverse(courseNames);
            foreach (var course in courseNames)
            {
                Console.WriteLine("The list of courses available in reverse are: {0}", course);
            }
        }

    }
}
