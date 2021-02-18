using System;
using System.Collections.Generic;
using System.Text;

namespace Donguler
{
    class HomeWork
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunKodu = 3321;
            urun1.urunAdi = "Keçi Peyniri";
            urun1.urunFiyatı = 50.00;
            urun1.urunMarkası = "Doğan";

            Urun urun2 = new Urun();
            urun2.urunKodu = 2856;
            urun2.urunAdi = "Acılı Sucuk";
            urun2.urunFiyatı = 80.00;
            urun2.urunMarkası = "Şahin";

            Urun urun3 = new Urun();
            urun3.urunKodu = 1030;
            urun3.urunAdi = "Sırt Pastırma";
            urun3.urunFiyatı = 140.00;
            urun3.urunMarkası = "Şahin";

            Urun[] Urun = new Urun[] { urun1, urun2, urun3 };

            Console.WriteLine("-----For Döngüsü------");
            {
                for (int i = 0; i < Urun.Length; i++)
                {
                    Console.WriteLine(Urun[i].urunKodu + " - " + Urun[i].urunAdi + " - " + Urun[i].urunFiyatı + " - " + Urun[i].urunMarkası + " - ");
                }
            }

            Console.WriteLine("-----While döngüsü-----");
            int sayac = 0;
            while (sayac < Urun.Length)
            {
                Console.WriteLine(Urun[sayac].urunKodu + " - " + Urun[sayac].urunAdi + " - " + Urun[sayac].urunFiyatı + " - " + Urun[sayac].urunMarkası + " - ");
                sayac++;
            }

            Console.WriteLine("-----Foreach döngüsü-----");
            foreach (var urun in Urun)
            {
                Console.WriteLine(urun.urunKodu + " - " + urun.urunAdi + " - " + urun.urunFiyatı + " - " + urun.urunMarkası + " - ");
            }
            Console.WriteLine("---------------");
            Console.WriteLine("---------------");
            Console.WriteLine("---------------");

        }

    }

    class Urun
    {
        public int urunKodu { get; set; }
        public string urunAdi { get; set; }
        public double urunFiyatı { get; set; }
        public string urunMarkası { get; set; }
    }
}
