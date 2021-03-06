using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " eklendi");
        }
        public void Sil()
        {
            Console.WriteLine("Müşteri silindi");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + ". " + musteri.Ad + " " + musteri.Soyad);
            }
        }
    }
}
