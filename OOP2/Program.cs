using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demiroğ";
            //musteri1.Id = 1;                      GEREK KALMADI.
            //musteri1.TcNo = "2222222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";    

            // Gerçek Müşteri- Tüzel Müşteri
            // SOLID 


            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";



            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

                               // referans no'su
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //miras olarak atadığımız için 'Musteri' her ikisini de referans no'sunu tutabildi.

            CustomerManager customerManager = new CustomerManager();

            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
            customerManager.Ekle(musteri3);
            customerManager.Ekle(musteri4);






        }
    }
}
