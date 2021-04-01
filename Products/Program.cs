using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.UrunAdi = "koltuk";
            product1.Fiyati = 1250;

            Product product2 = new Product();
            product2.Id = 2;
            product2.UrunAdi = "sandalye";
            product2.Fiyati = 520;

            Product product3 = new Product();
            product3.Id = 3;
            product3.UrunAdi = "masa";
            product3.Fiyati = 789;

            Product[] products = new Product[]
            {
                product1, product2, product3
            };

            Console.WriteLine("For döngüsü ile:");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine((i + 1) + ". ürünün adı: " + products[i].UrunAdi + " fiyatı: " + products[i].Fiyati);
            }

            Console.WriteLine("\nForeach dögüsü ile: ");

            foreach (var product in products)
            {
                Console.WriteLine(product.Id + ". ürünün adı: " + product.UrunAdi + " fiyatı: " + product.Fiyati);
            }

            Console.WriteLine("\nWhile dögüsü ile: ");
            int l = 0;
            while (l < products.Length)
            {
                Console.WriteLine(products[l].Id + ". ürünün adı: " + products[l].UrunAdi + " fiyatı: " + products[l].Fiyati);
                l++;
            }


            Console.ReadLine();
        }
    }
}
