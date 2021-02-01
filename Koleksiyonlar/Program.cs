using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            //isimler = new string[5]; >>> new dediğimiz anda bellekte yeni bir adres oluşur ve atanmayanlar boştur
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);
            // dizileri genişletirsek diğer elemanları kaybediyoruz yukarıda bu yüzden dizilerle(array) çalışmıyoruz !koleksiyonlar! 

            // CTRL + k + c  toplu command satırı << geri almak için CTRL + k + u

            // list sınıfı eklenmeli ampulle
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            // isimler.Add("Betül"); şeklinde listeye eleman ekleyebiliriz.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }

    }
}
