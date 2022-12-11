using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursOrnekleri
{
    class Kisi
    {
        private int yas;


        public int Yas
        {
            get { return Yas; }
            set
            {
                if (value <= 64 && value >= 18)
                {
                    yas = value;
                }
                else
                {
                    yas = 18;
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Kisiler.Skorlar skorlar = new Kisiler.Skorlar();
                skorlar.Skor = 5;
                Console.WriteLine("Skor: " + skorlar.Skor);


                /*
                 Kisi Nihat = new Kisi
                {
                    yas = 55
                };
                 */

                Kisi Nihat = new Kisi();
                Nihat.yas = 55;

                Console.WriteLine(Nihat.yas);




               

                Console.ReadKey();
            }
        }
    }
}
