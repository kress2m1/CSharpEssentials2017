﻿using System;
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
            Console.WriteLine(ageofStudents[2]);

       }

       public void TeacherName()
       {
           string[] teacherName = {"Ayo", "Anita", "Kay", "Tony", "James"};
       }

       public void CourseNames()
       {
           string[] courseNames = new[] {"Java", "C#", "C++"};

       }
   }
}
