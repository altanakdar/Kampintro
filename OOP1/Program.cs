using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitsInStock = 500;
            product1.UnitPrice = 3;


            Product product2 = new Product() { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitsInStock = 2, UnitPrice = 2 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
               





        }
    }
}   
