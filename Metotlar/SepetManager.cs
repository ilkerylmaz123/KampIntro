﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi:" + urun.Adi);
        }

        public void Ekle2(string urunadi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urunadi);
        }
    }
}
