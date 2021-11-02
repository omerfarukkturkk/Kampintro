using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // toplu comment için ctrl+k+c
            // toplu comment iptali ctrl+k+u
            //string[] isimler = new string[] { "ömer", "murat", "taha", "emre" };
            //console.writeline(isimler[0]);
            //console.writeline(isimler[1]);
            //console.writeline(isimler[2]);
            //console.writeline(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "ilker";
            //console.writeline(isimler[4]);
            //console.writeline(isimler[0]);
            //sıfırıncı elemanı boş yazar çünkü dizinin sadece 5. elemanı dolu.  
            //ikinci new atamayla yeni bir referans/adres oluşturuldu.

            List<string> isimler2 = new List<string> {"Ömer","Murat","Taha","Emre" };
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
