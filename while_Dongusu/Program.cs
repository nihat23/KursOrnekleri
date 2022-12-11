using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int uretilenSayi = rnd.Next(1, 10);
            int sayi3 = 0, hak3 = 5;
            Console.WriteLine("Uretilen Sayı:" + uretilenSayi);
            do
            {
                Console.Write("Bir Tahminde Bulununuz..");
                sayi3 = Convert.ToInt32(Console.ReadLine());
                hak3--;
                Console.WriteLine("Kalan Hakkınız:{0}", hak3);

                if (sayi3 < uretilenSayi)
                {
                    Console.WriteLine("Sayıyı büyültünüz...");
                }
                else if (sayi3 > uretilenSayi)
                {
                    Console.WriteLine("Sayıyı küçültünüz..");
                }
                else
                {
                    Console.WriteLine("Tbr Dogru Tahminde Bulundunuz.." + uretilenSayi);
                }

                if (hak3 == 0)
                {
                    Console.WriteLine("Hakkınız Tükenmiştir..");
                }

            } while (sayi3 != uretilenSayi && hak3 != 0);



            Console.ReadLine();

            int sayi2 = 0, toplam2 = 0;

            do
            {
                Console.Write("Bir Sayı Giriniz.. ");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                toplam2 += sayi2;
            } while (sayi2 != 0);

            Console.WriteLine("Sayıların toplamı:{0} ", toplam2);

            Console.ReadLine();

            string S_ad = "admin", S_sifre = "123";
            string KullaniciAd, KullaniciSifre;
            int hak = 3;

            do
            {
                Console.Write("Kullanıcı Adınızı Giriniz... ");
                KullaniciAd = Console.ReadLine();
                Console.Write("Kullanıcı sifrenizi giriniz.. ");
                KullaniciSifre = Console.ReadLine();

                if (S_ad == KullaniciAd && KullaniciSifre == S_sifre)
                {
                    Console.WriteLine("Sisteme HoşGendiniz..");
                }
                else
                {
                    hak--;
                    if (hak == 0)
                    {
                        Console.WriteLine("3 Defa yanlış yaptınız.. Müsteri hizmetlerini arayınız..");
                    }
                }

            } while ((KullaniciAd != S_ad || KullaniciSifre != S_sifre) && hak != 0);

            Console.ReadLine();

            int sayac2 = 1;
            do
            {
                Console.WriteLine(sayac2);
                sayac2++;
            } while (sayac2 <= 4);



            Console.ReadLine();


            int x = 1;

            while (x <= 100)
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine(x);
                }
                x++;
            }
            //1.ornek
            int sayac = 1, toplam = 0;

            while (sayac <= 2)
            {
                Console.Write("{0}. Sayıyı Giriniz..", sayac);
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
                sayac++;
            }
            Console.WriteLine("Sayıların toplamı:{0} ", toplam);

            Console.ReadLine();

            //2.ornek
            int sayac1 = 1, toplam1 = 0;
            Console.Write("Kaç Adet sayı  Gireceksiniz..");
            int adet1 = Convert.ToInt32(Console.ReadLine());
            while (sayac1 <= adet1)
            {
                Console.Write("Sayı Giriniz... ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                toplam1 += sayi1;
                sayac1++;
            }
            int ortalama1 = toplam1 / adet1;
            Console.WriteLine("Girmiş oldugunuz sayıların ortalaması:{0} ", ortalama1);




            Console.ReadKey();
        }
    }
}
