using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gunler1 = new string[7] { "1", "2", "3", "4", "5", "6", "7" };
            string[] gunler2 = new string[7] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            Console.WriteLine("Haftanın {0}. Günü  {1} Günüdür ", gunler1[4], gunler2[4]);

            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(gunler1[i] + "-" + gunler2[i]);
            }

            Console.ReadKey();

            string[] isimler = new string[7] { "Sinan", "Sibel", "Fethi", "Metin", "Nihal", "Nihat", "mehmet" };

            Array.Clear(isimler, 0, 3);
            Array.Sort(isimler);
            Console.WriteLine("Diziin Toplam Sayısı:{0}", isimler.Length);
            int siralama = Array.IndexOf(isimler, "Nihat");
            Console.WriteLine("Sıra:{0}.", siralama);

            foreach (string item in isimler)
            {
                Console.WriteLine("silinenden kalan isimler:{0}", item);
            }

            Console.ReadKey();
        }
    }
}
