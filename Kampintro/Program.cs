using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //Console.WriteLine("Kategori"); böylesinde tek tek yazılaması kendini tekrarlar DO NOT REPEAT YOURSELF!!
            //değer tutucu

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }


            //şart parantezin içine yazılır.
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }



            Console.WriteLine(kategoriEtiketi);


        }
    }
}
