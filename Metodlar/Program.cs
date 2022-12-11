using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            yaz();
            ornekSinif.yaz1();//stattik 

            string yazi = "  5 kez Yazılacak yazı yazdırıldı... ";//1

            yaziYaz(yazi);

            int sonuc = topla(18, 6);
            Console.Write("Toplam Sonuc:{0}", sonuc);
            Console.WriteLine();

            Console.Write("kısa kenar uzunlugu giriniz..: ");
            double kk = Convert.ToDouble(Console.ReadLine());
            Console.Write("uzun kenar uzunlugu giriniz..: ");
            double uk = Convert.ToDouble(Console.ReadLine());
            double dikdortgenalan = AlanCevreHesapla.alanHesapla(kk, uk);
            double dikdortgencevre = AlanCevreHesapla.cevreHesapla(kk, uk);
            Console.Write("Dikdörtgenin Alanı:{0} ---- Dikdörtgenin Çevresi:{1}", dikdortgenalan, dikdortgencevre);


            Console.ReadKey();
        }

        class AlanCevreHesapla
        {
            internal static double alanHesapla(double kisakenar, double uzunkenar)
            {
                double alan = kisakenar * uzunkenar;
                return alan;
            }

            public static double cevreHesapla(double kisaKenar, double uzunKenar)
            {
                double cevre = 2 * (kisaKenar + uzunKenar);
                return cevre;

            }
        }

        static int topla(int s1, int s2)
        {
            return s1 + s2;
        }
        static void yaziYaz(string yazi)//1
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i + "." + yazi);
            }
        }



        class ornekSinif
        {
            public static void yaz1()//statık olmak zorunda
            {
                Console.WriteLine("ÖrnekClass Sınıfı Calıstı..");
            }
        }




        static void yaz()
        {
            Console.Write("C# Metodlar Ögreniyorum ");
        }
    }
}
