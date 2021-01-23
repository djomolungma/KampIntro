using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //İnterface = Şablon ,Referas tutucu
    //Birisu bu interface yi kullanıyor ise içerisindeki method'ladı kullanmalı
    //Okunurluğu arttırmak için interface'ler I harfi ile baslatılmalı
    //Interface'ler operasyonel metotlarda kullanılır
    //Birbirlerinin alternatifi olan ana kod içeriklerinin farklı olduğu durumlarda kullanılır

    interface IKrediManager
    {
        void Hesapla();
        void BirseyYap();
    }
}
