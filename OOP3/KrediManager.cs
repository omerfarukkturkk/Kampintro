using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //I harfiyle başlar interface
    //genellikle operasyonel metotlarda kullanılır.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();

        //***interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan
        //durumlar için kullanılır***

        //loglama= kim,hangi operasyonu nerede çağırdı..
    }
}
