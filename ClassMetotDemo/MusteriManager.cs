using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEklendi(Musteri musteri)
        {
            Console.WriteLine("Müşteri listeye eklendi. Hoşgeldiniz Sayın " + musteri.MusteriAdi + " ");
            Console.WriteLine("Müşteri numaranız : " + musteri.Id);
        }

        public void MusteriSilindi(Musteri musteri)
        {
            Console.WriteLine("Müşteri başarıyla silindi. Hoşçakal " + musteri.MusteriAdi + " ");
        }

        public void MusteriDegisti(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri başarıyla değiştirildi.");
            Console.WriteLine("Yeni bilgileriniz E-posta yoluyla iletilecektir. Sayın " + musteri.MusteriAdi + " ");
        }

    }
}
