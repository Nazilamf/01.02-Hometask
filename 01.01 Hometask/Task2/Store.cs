using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    internal class Store
    {
        static public Product[] Products = new Product[0];




        public void AddProduct(Product pr)
        {
            Array.Resize(ref Products, Products.Length+1);
            Products[Products.Length-1] = pr;

        }


        static public bool HasProductbyNo(int No)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == No)
                {
                    return true;
                }
            }
            return false;
        }



        public Product GetProductByNo(int No)
        {



            for (int i = 0; i < Products.Length; i++)
            {

                if (HasProductbyNo(No))
                {
                   
                    Products[i] = Store.Products[i];
                }

                else throw new ProductNotFoundException();
            }

           return Store.Products[i];
        }






    }
}

