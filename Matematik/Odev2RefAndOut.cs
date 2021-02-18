using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class Odev2RefAndOut
    {

        public static void Main(string[] args)
        {

            int sayi1 = 22;
            int sayi2 = 44;
            int sayi3;

            int sonuc = Cıkar(sayi1, sayi2);
            Console.WriteLine(sayi1);

            int sonuc2 = Cıkar2(ref sayi1, sayi2);
            Console.WriteLine(sayi1);

            int sonuc3 = Cıkar3(out sayi3, sayi2);
            Console.WriteLine(sayi3);

        }
        static int Cıkar(int sayi1, int sayi2)
        {
            sayi1 = 22;
            int sonuc = sayi1 - sayi2;
            return sonuc;

        }
        static int Cıkar2(ref int sayi1, int sayi2)
        {
            sayi1 = 22;
            int sonuc = sayi1 - sayi2;
            return sonuc;
        }

        static int Cıkar3(out int sayi1, int sayi2)
        {
            sayi1 = 22;
            int sonuc = sayi1 - sayi2;
            return sonuc;


        }

    }
