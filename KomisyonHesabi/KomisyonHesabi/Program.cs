using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomisyonHesabi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden 5 malın değeri alınacaktır. Fiyatı 50 tl ye kadar olanlardan %3, 50 tl den fazla olanlardan ise %2 komisyon alınacaktır.
               5 maldan elde edilen toplam komisyonu ekrana yazdıran program */

            double top = 0;

            for (int sayac=5; sayac>0; sayac--)
            {

                Console.Write("Malın Fiyatını Giriniz: ");
                double x = Convert.ToDouble(Console.ReadLine());

                if (50<x)
                {
                    x *= 0.03;
                    top += x;
                }
                else
                {
                    x *= 0.02;
                    top += x;
                }
            }

            Console.WriteLine("Toplam Komisyon Miktarı: " + top);
            Console.ReadKey();

        }
    }
}
