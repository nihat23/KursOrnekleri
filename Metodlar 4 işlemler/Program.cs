using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar_4_işlemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4 işlem Hesaplama");
        Yeniden:
            Console.Write("1.Sayı Giriniz...:");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.sayı giriniz...:");
            double s2 = Convert.ToDouble(Console.ReadLine());

        secimYapp:
            Console.Write("Lütfen seçiminizi yapınız.. 1-Toplama 2-Çıkar 3-Çarpma 4-Bölme Seçim:");
            char secimYap = Convert.ToChar(Console.ReadLine()); 
            switch (secimYap)
            {
                case '1':
                    Dortislemler toplam = new Dortislemler();
                    double ToplamSonuc = toplam.topla(s1, s2);
                    Console.WriteLine("Toplam:{0}", ToplamSonuc);
                    break;
                case '2':
                    Dortislemler cikarma = new Dortislemler();
                    double cikarSonuc = cikarma.cikar(s1, s2);
                    Console.WriteLine("Cıkarma Sonuc:{0}", cikarSonuc);
                    break;
                case '3':
                    Dortislemler carpma = new Dortislemler();
                    double carpmaSonuc = carpma.carpma(s1, s2);
                    Console.WriteLine("Çarpma Sonuc:{0}", carpmaSonuc);
                    break;
                case '4':
                    Dortislemler bolmee = new Dortislemler();
                    double bolmeSonuc = bolmee.bol(s1, s2);
                    Console.WriteLine("Bölme Sonuc:{0}", bolmeSonuc);
                    break;

                default:
                    Console.Write("Yanlış bir işlem girdiniz.. Yeniden Seçim yapınız..");
                    goto secimYapp;
                    //break; 
            }

        tekrardan:
            Console.Write("Tekrar Hesap Yapmak istiyormusunuz.. (E yada H) Seçim: ");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim == 'E' || secim == 'e')
            {
                Console.Clear();
                goto Yeniden;
            }
            else if (secim == 'H' || secim == 'h')
            {
                Console.WriteLine("İyi Günler Dilerim..");
            }
            else
            {
                Console.WriteLine("Yanlıs bir karaktere bastınız..");
                goto tekrardan;

            }

            Console.ReadKey();

        }

        class Dortislemler
        {

            internal double topla(double s1, double s2)
            {
                return s1 + s2;
            }
            public double cikar(double s1, double s2)
            {
                return s1 - s2;
            }
            internal double carpma(double s1, double s2)
            {
                return s1 * s2;
            }
            public double bol(double s1, double s2)
            {
                return s1 / s2;
            }
        }
    }
}
