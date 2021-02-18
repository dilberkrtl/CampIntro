using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    partial class Musteri
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Deniz Yıldırım";
            musteri1.Id = 12345678901;
            musteri1.DogumTarihi = 01 / 01 / 1988;
            musteri1.MusteriNumarasi = 445669;
            musteri1.HesapNumarası = 1136 - 896773;
            musteri1.HesapTuru = "Vadesiz";
            musteri1.DovizKodu = "TL";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Elif Yıldırım";
            musteri2.Id = 09876543212;
            musteri2.DogumTarihi = 30 / 05 / 1990;
            musteri2.MusteriNumarasi = 359933;
            musteri2.HesapNumarası = 1236 - 977986;
            musteri2.HesapTuru = "Vadesiz";
            musteri2.DovizKodu = "TL";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (var Musteri in musteriler)
            {
                Console.WriteLine(Musteri.MusteriAdi);
            }

            foreach (var Musteri in musteriler)
            {
                Console.WriteLine(Musteri.MusteriAdi + " : " + Musteri.DovizKodu);

            }

        }


        public string MusteriAdi { get; set; }
        public long Id { get; set; }
        public double DogumTarihi { get; set; }
        public int MusteriNumarasi { get; set; }
        public int HesapNumarası { get; set; }
        public string HesapTuru { get; set; }
        public string DovizKodu { get; set; }

    }

}









