﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKrediManager:IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }

        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        
    }
}
