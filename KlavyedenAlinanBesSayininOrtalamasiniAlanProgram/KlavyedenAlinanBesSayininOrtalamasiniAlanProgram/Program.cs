using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlavyedenAlinanBesSayininOrtalamasiniAlanProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden alınan beş sayının ortalamasını bulup ekrana yazdıran program */

            int top = 0;

            for (int sayac=5; sayac>0; sayac--)
            {
                Console.Write("Sayı Giriniz: ");
                int x = Convert.ToInt32(Console.ReadLine());
                top += x;
            }

            int ort = top / 5;

            Console.WriteLine("Beş Sayının Ortalaması: " + ort);
            Console.ReadKey();
        }
    }
}
