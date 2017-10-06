using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_C_Coding_Class.ArraysClass
{
   public class DiscussingArrays
   {
        //to define an array - datatype[] arrayName;
       public void AgeofStudents()
       {
           double[] ageofStudents = new double[3];
           ageofStudents[0] = 23;
           ageofStudents[1] = 22;
           ageofStudents[2] = 25;

            Console.WriteLine(ageofStudents[0]);
            Console.WriteLine(ageofStudents[1]);
            Console.WriteLine(ageofStudents[2]);//test

       }

       public void TeacherName()
       {
           string[] teacherName = {"Ayo", "Anita", "Kay", "Tony", "James"};
           foreach (var teacher in teacherName)
           {
               Console.WriteLine("The names of the teachers are: {0} ", teacher);
           }
           Console.WriteLine("------------------");
            Array.Sort(teacherName);
           foreach (var teacher in teacherName)
           {
                Console.WriteLine("The names of the teachers are: {0} ", teacher);
            }
       }

       public void CourseNames()
       {
           string[] courseNames = new[] {"Java", "C#", "C++"};
           foreach (var course in courseNames)
           {
               if (!course.Equals("C#"))
               
               Console.WriteLine("The courses available include: {0}", course);
               break;

                //Another way to write above is below
                //// if (course.Equals("C#"))

                //Console.WriteLine("The courses available include: {0}", course);
                //break;
                //Console.WriteLine("The courses available names are: {0}", course);
            }
           Array.Reverse(courseNames);
           foreach (var course in courseNames)
           {
               Console.WriteLine("The List of courses in reverse are: {0}", course);
           }
       }
   }
}
