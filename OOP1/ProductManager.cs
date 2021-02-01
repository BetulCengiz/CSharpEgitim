using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //ProductManager = CRUD operasyonları içerir gibi anlayabilirsin

        public void Add(Product product)
        {

            Console.WriteLine(product.ProductName + " eklendi,");
        }
        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        public int Topla(int sayi1,int sayi2) 
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2); 
        }




        // void ne işe yarar?.>>.void ile sonucu tutamayız sonucu tutmak istersek public int gibi bir sistem kullanmalıyız.
        // void kullanırsak herhangi bir sonucu başka yerde kullanamayız.
    }
}
