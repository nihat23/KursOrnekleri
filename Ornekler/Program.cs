using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {

        basadon:
            Console.Clear();

            Console.Write("1.Yazılı Notunuzu Giriniz..: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Yazılını Notunuzu Giriniz..: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3.Yazılı Notunuzu Giriniz..: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            int ort = (y1 + y2 + y3) / 3;
            Console.WriteLine("Ortalama:{0}", ort);

        secimYap:
            Console.Write("Tekrar işlem yapmak  istermisiniz.. (e / h) ? ");
            char secim = Convert.ToChar(Console.ReadLine());

            if (secim == 'e' || secim == 'E')
            {
                goto basadon;
            }
            else if (secim == 'h' || secim == 'H')
            {
                Console.WriteLine("İyi Günler Dilerim..");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Yanlış Bir Sçim Yaptınız.. Tekrardan Deneyiniz..");
                goto secimYap;

            }
            Console.ReadKey();


        }

    }
}
