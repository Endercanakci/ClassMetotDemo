using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Sayın"+" "+musteri.MusteriAdi+" "+musteri.MusteriSoyadi+" Müşteri kimliğiniz oluşturuldu");
        }

        public void Add1(string MusteriAdi, string MusteriSoyadi, int Id, double CuzdanBakiyesi)
        {
            Console.WriteLine("Sayın"+" "+ MusteriAdi+" "+MusteriSoyadi + " Müşteri kimliğiniz oluşturuldu");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Sayın" + " " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi +" MÜşteri kimliğiniz silindi!");
        }
    }
}
