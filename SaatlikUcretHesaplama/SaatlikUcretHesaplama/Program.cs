using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaatlikUcretHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Klavyeden saatlik ücret ve işçinin kaç saat çalıştığı bilgileri alınaraktan;
               40 saat ve altı için --> saatlik ücret * işçi saati,
               40 saat üstü için --> 40 saati geçen her saat 2x saat sayılacak
               Hesaplayıp ekrana yazdıran program.
            */


            int ucret = 0;

            Console.Write("Saat Ücretini Giriniz: ");
            int SaatU = Convert.ToInt32(Console.ReadLine());

            Console.Write("İşçi Çalışma Saatini Giriniz: ");
            int IsciS = Convert.ToInt32(Console.ReadLine());

            if (IsciS<=40)
            {
                ucret = SaatU * IsciS;
                Console.WriteLine("Ödenecek Tutar: " + ucret);
                Console.ReadKey();
            }
            else
            {
                ucret = (((IsciS - 40) * 2) + 40) * SaatU;
                Console.WriteLine("Ödenecek Tutar: " + ucret);
                Console.ReadKey();
            }

        }
    }
}
