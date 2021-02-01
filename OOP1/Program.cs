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
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 5 };


            //PascalCase  //camelCase
            //case sensitive(büyük küçük harf duyarlılığı
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            // int,double,bool....değer tip >>bağlantı kopar değişmez
            // diziler,class,abstraact class,interface..... referans tip >> değişir

            //void vs int...
            productManager.Topla2(3, 6);

            
            int sonuc = productManager.Topla(3, 6);
            Console.WriteLine(sonuc*5);
        }
    }
}
