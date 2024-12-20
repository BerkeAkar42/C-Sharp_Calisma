using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekveCiftSayilaraGoreHesaplatma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden girilen N sayısına göre 1 den N'ye kadar olan tek sayıların toplamı ve çarpımı,
               Çift sayıların ise karelerinin toplamını bulan program */

            int tek = 0;
            int cift = 0;
            int tekc = 1;


            Console.Write("Sayı Giriniz: ");
            int N = Convert.ToInt32(Console.ReadLine());

            while (N>0)
            {
                if (N % 2==0)
                {
                    cift = (N * N) + cift;
                }
                else
                {
                    tek += N;
                    tekc *= N;
                }
                N--;
            }

            Console.WriteLine("Tek Sayıların Toplamı: " + tek);
            Console.WriteLine("Tek Sayıların Çarpımı: " + tekc);
            Console.WriteLine("Çift Sayıların Kareleri Toplamı: " + cift);
            
            Console.ReadKey();
        }
    }
}
