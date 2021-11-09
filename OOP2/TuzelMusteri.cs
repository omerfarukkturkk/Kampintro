using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    //miras=inheritance***
    //iki farklı sınıfı tek bir yerde toplamak için atarız.
    class TuzelMusteri:Musteri
    {
        //sadece ona ait özellikler burada
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }

    }
}
