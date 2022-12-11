using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Türleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tc = 1234567891;
            string adi = "Nihat";
            string Soyad = "Beyi";
            double maas = 8.500;

            string birlestir = string.Concat("Tc Numarası: " + tc + " Adı:" + adi + " Soyadı:" + Soyad + " Maaş:" + maas);
            Console.WriteLine(birlestir);

            //1.ornek
            int karsilastirma = String.Compare("admin", "admin");
            Console.WriteLine("Birbirinden aynı:{0}", karsilastirma);

            int karsılastir = string.Compare("admin", "Admin");
            Console.WriteLine("Birbirinden farklı:{0}", karsılastir);

            Console.Write("Lütfen kullanıcı adınızı giriniz..: ");
            string ad = Console.ReadLine();
        tekrarsifre:
            Console.Write("Lütfen şifrenizi giriniz..: ");
            string sifre1 = Console.ReadLine();
            Console.Write("Lütfen şifrenizi tekrardan giriniz..: ");
            string sifre2 = Console.ReadLine();

            int kontrol = string.Compare(sifre1, sifre2);
            if (kontrol == 0)
            {
                string sifre = sifre2;
                Console.WriteLine("Kullanıcı adı:{0} şifre:{1}", ad, sifre, true);//buyuk kucuk harf duyarlılık
                Console.WriteLine("şifreniz başarılı");
            }
            else if (kontrol == -1)
            {
                Console.WriteLine("şifreniz birbiriyle uyuşmuyor");
                goto tekrarsifre;
            }
            else
            {
                //sifre 1 olması durumunda
                Console.WriteLine("Şifreniz birbiriyle uyuşmuyor...");
                goto tekrarsifre;
            }
            Console.ReadKey();
        }
    }
}
