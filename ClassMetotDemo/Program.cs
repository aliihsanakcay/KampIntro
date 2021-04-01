using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri { Id = 1, Ad = "Ali İhsan", Soyad = "Akçay"};
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);

            Console.ReadLine();
        }
    }
}
