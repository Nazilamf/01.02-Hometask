using System;
using System.Dynamic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           Product[] product = new Product[4];
            Store Store = new Store();

            Product product1 = new Product()
            {
                No= 1,
                Category = "Drink",
                Price =5
            };




            Product product2 = new Product()
            {
                No= 2,
                Category = "Chocolate",
                Price =2
            };


            Product product3 = new Product()
            {
                No= 3,
                Category = "Fruits",
                Price =3
            };


            Product product4 = new Product()
            {
                No= 4,
                Category = "Milk",
                Price =2.50
            };


            Store.Products[0] = product1;
            Store.Products[1] = product2;
            Store.Products[2] = product3;
            Store.Products[3] = product4;


            Store.GetProductByNo(3);

            for (int i = 0; i < Store.Products.Length; i++)
            {

                Console.WriteLine(Store.Products[i]);
            }







            Product[] products = new Product[0];

            string option;

            do
            {

                Console.WriteLine("1.Product elave et");
                Console.WriteLine("2.Butun productlara bax");
                Console.WriteLine("3.Verilmis nomreli producta bax");
                Console.WriteLine("0.Menudan cix");

                Console.WriteLine("Secim edin");
                option = Console.ReadLine();

                switch (option)
                {

                    case "1":

                        Store.AddProduct(product1);
                        break;

                    case "2":
                        foreach (Product Products in products)
                            Console.WriteLine($"No: {Products.No} - Category: {Products.Category} - Price : {Products.Price}");

                        break;

                    case "3":

                        string No = Console.ReadLine();
                        int value = Convert.ToInt32(Console.ReadLine());
                        foreach (Product Products in products)
                        {
                            if (Store.Products[i].No == value)
                            {
                                Console.WriteLine($"No: {Products.No} - Category: {Products.Category} - Price : {Products.Price}");
                            }

                        }
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Seciminiz yanlisdir!");
                        break;

                }




            } while (option != "0");


















        }
    }
}
