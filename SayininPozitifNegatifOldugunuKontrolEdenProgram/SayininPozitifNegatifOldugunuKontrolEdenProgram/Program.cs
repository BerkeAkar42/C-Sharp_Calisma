using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayininPozitifNegatifOldugunuKontrolEdenProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden alınan sayının pozitif mi negatif mi olduğunu kontrol edip bunu ekrana yazdıran prgoram */


            Console.Write("Sayı Giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x>0)
            {
                Console.WriteLine("Sayınız Pozitiftir.");
            }
            else if (x<0)
            {
                Console.WriteLine("Sayınız Negatiftir.");
            }
            else
            {
                Console.WriteLine("Sayınız Sıfırdır.");
            }

            Console.ReadKey();

        }
    }
}
