using System;
using System.Collections.Generic;
using System.Text;

namespace _01._01_Hometask
{
    internal class Course
    {
       public  Student[] Students = new Student[0] ;
        public int StudentsLimit;




        public void AddStudent(Student std)
        {
            if(Students.Length < StudentsLimit)
            {
                if (!HasStudentbyNo(std.No))
                {
                    Array.Resize(ref Students, Students.Length+1);
                    Students[Students.Length-1] = std;
                }
                
            }
            


        }

        //Kursda verilmis nomreli telebenin olub olmadigini tapan metod

        public bool HasStudentbyNo(int no)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].No == no)
                {
                    return true;
                }
                
            }
            return false;
        }



    }
}
