using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class Product
    {
        public int No;
        public string Category;
        public double Price;



        public int totalcount;

        public Product()
        {
            totalcount++;
            No = totalcount;
        }

        

    }
}
