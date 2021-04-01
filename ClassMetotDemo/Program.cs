using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Akcay";
            musteri1.Yas = 27;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Ahmet";
            musteri2.Soyad = "Mete";
            musteri2.Yas = 21;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Ayşe";
            musteri3.Soyad = "Can";
            musteri3.Yas = 22;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine();

            Console.WriteLine("Müşteriler listesi:");
            musteriManager.Listele(musteriler);


            Console.ReadLine();
        }
    }
}
