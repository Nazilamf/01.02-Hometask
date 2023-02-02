using System;
using System.Security.Cryptography.X509Certificates;

namespace _01._01_Hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Hello World!");


            Course Course1 = new Course();
            Course1.StudentsLimit = 5;
            Course1.Students = new Student[3];

              


            Student std1 = new Student
            {
                FullName = "Leyla Quliyeva",
                Group = "P231",
                Point = 95,

            };

            Student std2 = new Student
            {
                FullName = "Nicat Bayramov",
                Group = "K231",
                Point = 85,

            };


            Student std3 = new Student
            {
                FullName = "Nermin Salimova",
                Group = "V231",
                Point = 90,

            };

            Course1.Students[0]= std1;
            Course1.Students[1]= std2;
            Course1.Students[2]= std3;

            Console.WriteLine(Course1.Students.Length);
            foreach (Student std in Course1.Students)
            {
                Console.WriteLine(std.FullName);
                    
            }



            Course1.AddStudent(std1);



            int num = 15;
            TryConvertTo("hybvh", out num);
            Console.WriteLine(num);

            


        }



       



       static void TryConvertTo(string str,out int num)
        { 
            
            try
            {
             num =Convert.ToInt32(str);
            }
            catch (Exception)
            {
                num = 0;
            }
            
        }






    }
}

