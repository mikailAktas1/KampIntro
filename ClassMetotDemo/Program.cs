using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new  Musteri();
            musteri1.Adi = "mikail ";
            musteri1.Soyadi = "aktaş";
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "seda ";
            musteri2.Soyadi = "aktaş";
            musteri2.Id = 2;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "gönenç ";
            musteri3.Soyadi = "aktaş";
            musteri3.Id = 3;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("----------------Musteriler Eklendi-------------");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            Console.WriteLine("----------------Musteriler Silindi-------------");
            musteriManager.Sil(musteri3);
            Console.WriteLine("----------------Musteriler Listelendi-------------");
            musteriManager.Listele(musteriler);

        }
    }
}
