using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        //interface kuralları içerir ve bağlandığı classlar o kuralları kendine göre doldurur.
        //operasyonel metotlarda kullanılır
        //şablon ve referans  tutar
        //interfaceler birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanılır.
        //örn: kredi hesaplama, geri ödeme yöntemi aynıdır. ancak kodları farklıdır. faiz oranları vs.
        void Hesapla();
        void BiseyYap();

        
           
        
    }
}
