using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //<T> yazarız t harfi değişebilir her tür veri tipi verilebilir geniş bir çalışma tipi için mantıklı 
        // direk string ,int yazsaydık sadece yazdıımız veri tipi ile çalışabilirdik.
    {
        // methodun içinde değil class içinde her yerden erişebilirsin methoda yazsydın? 
        T[] items;
        //constructor bir metottur. constructor olduğunu class ile aynı isimde olmasından anlarsın
        public MyList() // class newlenirse otomatik çalışır
        {
            items = new T[0]; //array sıfırlandı ve 0 elemanlı olarak newlendi 
        }
        public void Add(T item)
        {
            // referans numarası tutturma
            T[] tempArray = items; // önceki deerleri korumak için geçici bir referans tutucu 
            items = new T[items.Length+1]; //dizinin eleman sayısını verir Lenght 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
