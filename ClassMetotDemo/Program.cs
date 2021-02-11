using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Ender";
            musteri1.MusteriSoyadi = "Çanakcı";
            musteri1.Id = 123;
            musteri1.CuzdanBakiyesi = 128.96;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Taha Osman";
            musteri2.MusteriSoyadi = "Varol";
            musteri2.Id = 321;
            musteri2.CuzdanBakiyesi = 684.75;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı : "+musteri.MusteriAdi);
                Console.WriteLine("Müşteri soyadı : "+musteri.MusteriSoyadi);
                Console.WriteLine("Müşteri kimliği : "+musteri.Id);
                Console.WriteLine("Kullanılabilir limit : "+musteri.CuzdanBakiyesi+"TL");
                Console.WriteLine("---------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            Console.WriteLine("-------------");
            musteriManager.Add1("Engin", "Demiroğ", 159, 78000);
            musteriManager.Add1("Görkem", "Karadeniz", 951, 3576);
            Console.WriteLine("-----------------");
            musteriManager.Delete(musteri1);

        }
    }
}
