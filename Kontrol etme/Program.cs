using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrol_etme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ogrno, ad, soyad;
            basadon:
            Console.Write("Lütfen Ögrenci numarasını Giriniz..:");
            ogrno = Console.ReadLine();
            Console.Write("Lüfen Adınızı Giriniz..:");
            ad = Console.ReadLine();
            Console.Write("Lütfen Soyadınızı Giriniz..:");
            soyad = Console.ReadLine();

            if (string.IsNullOrEmpty(ogrno) == true || string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) == true)
            {
                Console.WriteLine("Boş Gecilmıs demektir..");
                goto basadon;
            }
            else
            {
                Console.WriteLine("Kayıt işlemi yapabilriniz..(dolu Demektir..)");//bos degil
                goto basadon;
            }


            Console.ReadKey();
        }
    }
}
