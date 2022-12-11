using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace islerler
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        basadon:
            double sayi1, sayi2,sonuc;
            char islem;

            Console.Write("lütfen 1. sayı giriniz... ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen 2.Sayı giriniz.. ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen bir seçim yapınız..? 1-Toplama 2-Çıkarma 3-Çarpma 4-Bölme 5-Mod al ");
            islem = Convert.ToChar(Console.ReadLine());
            if (islem == '1')
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine("2 Sayının Toplamı Sonucu:{0}",sonuc);
                goto basadon;
            }
            else if (islem == '2')
            {
                sonuc = sayi1 - sayi2;
                Console.WriteLine("2 Sayının çıkarma Sonucu:{0}",sonuc);
                goto basadon;
            }
            else if (islem == '3')
            {
                sonuc = sayi1 * sayi2;
                Console.WriteLine("2 Sayının çarpma sonucu:{0}",sonuc);
                goto basadon;
            }
            else if (islem == '4')
            {
                sonuc = sayi1 / sayi2;
                Console.WriteLine("2 Sayının Bölme Sonucu:{0}", sonuc);
                goto basadon;
            }
            else
            {
                sonuc = sayi1 % sayi2;
                Console.WriteLine("2 Sayının Mod alma Sonucu:{0}", sonuc);
                goto basadon;
            }

            Console.ReadKey();

        }
    }
}
