using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123654";
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Akçay";
            musteri1.TcNo = "325698741";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "2578896";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "587412369";

            // Gerçek Müşteri - Tüzel Müşteri
            //SO{L}ID in L prensibi 

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
            customerManager.Ekle(musteri3);
            customerManager.Ekle(musteri4);


            Console.ReadLine();
        }
    }
}
