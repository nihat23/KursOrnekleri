using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;//kutuphanemız

namespace Timer1
{
    internal class Program
    {

        public static int sure = 10; // public ile 
        static Timer sayac = new Timer();// private ile

        static void Main(string[] args)
        {
            Timer zamanliyici = new Timer();
            zamanliyici.Interval = 2000;// her 2 sanıyede 1 calısacak
            zamanliyici.Elapsed += Zamanliyici_Elapsed;
           // zamanliyici.Enabled = true;
            //zamanliyici.Start();            

           


            sayac.Interval = 1000;//her 5 sanıyede 1 kez tetıklenır..
            sayac.Elapsed += Sayac_Elapsed;
            sayac.Start();

            Console.ReadKey();
        }

        private static void Sayac_Elapsed(object sender, ElapsedEventArgs e)
        {
            sure--;
            Console.Clear();
            Console.WriteLine("Süre:{0}",sure);

            if (sure == 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Süre Bitmiştir..");                
                sayac.Stop();
               
            }

        }

        private static void Zamanliyici_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Zamanlanıyıcı calıstı");
        }


    }
}
