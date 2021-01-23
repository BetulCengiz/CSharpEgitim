using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{   //prop>>>snippet
    class Product
    {
        public int Id { get; set; }
        // kod okunurluğu için sıralama önemlidir 
        public int CategoryId { get; set; } 
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD operasyonları= silmek,eklemek,güncellemek gibi işlemlere denir

    }
}
