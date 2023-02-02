using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    internal class ProductNotFoundException:Exception
    {

        public ProductNotFoundException() : base("Mehsul tapilmadi")
        { 

        }

    }
}
