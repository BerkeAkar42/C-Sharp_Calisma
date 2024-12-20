using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenAlanHesabiYapanProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Kullanıcıdan dikdörtgenin kısa ve uzun kenarı alınarak alan hesabı yapan program */

            Kenar1Giris:
            Console.Write("Kısa Kenarı Giriniz: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            if (x1>0)
            {

                Kenar2Giris:
                Console.Write("Uzun Kenarı Giriniz: ");
                int x2 = Convert.ToInt32(Console.ReadLine());

                if (x2>0)
                {

                    int alan = x1 * x2;
                    Console.WriteLine("Alan: " + alan);
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Girilen Sayı Bir Uzunluk Belirtmemektedir! Lütfen Tekrardan Giriniz.");
                    goto Kenar2Giris;
                }
            }
            else
            {
                Console.WriteLine("Girilen Sayı Bir Uzunluk Belirtmemektedir! Lütfen Tekrardan Giriniz.");
                goto Kenar1Giris;
            }
        }
    }
}
