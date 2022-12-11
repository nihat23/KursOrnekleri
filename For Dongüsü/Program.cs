using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Dongüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int RastGeleSayi = rnd.Next(1, 25);
            Console.WriteLine("Üretilen Sayı:{0}", RastGeleSayi);
            int hak = 5;
        basadon:
            Console.Write("Bir tahminde Bulununuz..");
            int tahmin = Convert.ToInt32(Console.ReadLine());

            if (tahmin == RastGeleSayi)
            {
                Console.WriteLine("Tebrik ederim Puanınız:{0}", hak * 10);
            }
            else if (tahmin < RastGeleSayi)
            {
                hak--;
                if (hak == 0)
                {
                    Console.WriteLine("Hakkınız Kalmadı.. Kaybettiniz");
                }
                else
                {
                    Console.WriteLine("Tahmininizi büyütünüz.." + hak);
                    goto basadon;
                }
            }
            else if (tahmin > RastGeleSayi)
            {
                hak--;

                if (hak == 0)
                {
                    Console.WriteLine("Hakkınız Kalmadı .. KAybettiniz..");

                }
                else
                {
                    Console.WriteLine("Tahmininizi Küçültünüz..." + hak);
                    goto basadon;

                }
            }

            Console.ReadLine();
            Console.Clear();

            for (int i = 0; i <= 10; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("*");
            }

            Console.ReadLine();
            Console.Clear();
            for (int i = 0; i <= 50; i += 2)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("*");
            }

            Console.ReadLine();
            Console.SetCursorPosition(5, 3);

            Console.ReadLine();
            Console.Clear();

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz..", i);
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                if (sayi1 > 0)
                {
                    Console.WriteLine("Sayı Pozitiftir.." + sayi1);
                }
                else if (sayi1 < 0)
                {
                    Console.WriteLine("Sayı negatiftir.." + sayi1);
                }
                else
                {
                    Console.WriteLine("Sayı 0 dır..");
                }
            }


            Console.ReadLine();
            Console.Clear();


            for (int i = 0; i <= 100; i += 5)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();

            int sayi = 0, toplam = 0, ortalama = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz.. ", i);
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            }
            ortalama = toplam / 5;
            Console.WriteLine("Toplam:{0}", toplam);
            Console.WriteLine("Ortalama:{0} ", ortalama);

            Console.ReadKey();
        }
    }
}
