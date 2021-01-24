using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();//101
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitsStock = 3;

            Product product2 = new Product { Id = 2,CategoryId=5,UnitPrice=400,
                UnitsStock=56,ProductName="kalem" };
            //Pascalcase    //camelcase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

 


            //int ,dobuble,bool...değer tip
            //class,abscract class....referans tip
          
        }
    }
}
