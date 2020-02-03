using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dortislem
    //static kullanmadan yapılmıştır.
{
    class Program
    {
        static void Main(string[] args)
        {
            BASADON:
            Console.WriteLine("1. sayıyı giriniz");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("seçiminizi yapınız (toplama:1  çıkarma:2  bölme:3  çarpma:4");
            char sec = Convert.ToChar(Console.ReadLine());
        ISLEMSEC:
            switch (sec)
            {
                case '1':
                    dortislem toplamaislemi = new dortislem();
                    double toplam = toplamaislemi.topla(sayi1, sayi2);
                    Console.WriteLine("toplama sonucu: {0}", toplam);
                    break;
                case '2':
                    dortislem cikarmaislemi = new dortislem();
                    double fark = cikarmaislemi.cıkar(sayi1, sayi2);
                    Console.WriteLine("çıkarma sonucu: {0}", fark);
                    break;
                case '3':
                    dortislem bolmeislemi = new dortislem();
                    double bolum = bolmeislemi.bol(sayi1, sayi2);
                    Console.WriteLine("bölme sonucu: {0}", bolum);
                    break;
                case '4':
                    dortislem carpmaislemi = new dortislem();
                    double carpim = carpmaislemi.carp(sayi1, sayi2);
                    Console.WriteLine("çarpma sonucu: {0}", carpim);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Yanlış seçim yaptınız. Tekrar deneyiniz");
                    goto ISLEMSEC;
            }
            EVETHAYIRDON:
            Console.WriteLine("Yeniden işlem yapmak ister misiniz? (EVET : E  HAYIR : H )");
            Char evethayir = Convert.ToChar(Console.ReadLine());
            if (evethayir=='E'||evethayir=='e')
            {
                Console.Clear();
                goto BASADON;
            }
           else if (evethayir == 'H' || evethayir == 'h')
            {
                Console.WriteLine("İYİ GÜNLER...");
            }
            else
            {
                Console.WriteLine("Yanlış bir seçim yaptınız tekrar deneyiniz.");
                goto EVETHAYIRDON;
            }
            Console.ReadKey();
        }
        class dortislem
        {
            public double topla(double s1, double s2)
            {
                return (s1 + s2);
            }
            public double cıkar(double s1, double s2)
            {
                return (s1 - s2);
            }
            public double bol(double s1, double s2)
            {
                return (s1 / s2);
            }
            public double carp(double s1, double s2)
            {
                return (s1 * s2);
            }
        }
    }
}
