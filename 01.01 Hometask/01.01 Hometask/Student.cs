using System;
using System.Collections.Generic;
using System.Text;

namespace _01._01_Hometask
{
    internal class Student
    {

        public int No;
        public string FullName;
        public string Group;
        public int Point;


        public int totalcount;

        public Student() 
        {
            totalcount++;
            No = totalcount;
        }




    }
}
