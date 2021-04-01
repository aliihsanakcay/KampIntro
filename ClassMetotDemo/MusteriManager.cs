using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " eklendi");
        }
        public void Sil()
        {
            Console.WriteLine("Müşteri silindi");
        }
        public void Listele()
        {
            Console.WriteLine("Müşteriler listelendi");
        }
    }
}
