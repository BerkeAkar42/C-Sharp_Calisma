using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden alınan sayının faktoriyelini hesaplayan program */


            int sayac = 1;
            int sonuc = 1;

            Console.Write("Sayı Giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());

            while (sayac<=x)
            {
                sonuc *= sayac; //sonuc = sonuc * sayac;
                sayac++;
            }

            Console.WriteLine("Sonuc: " + sonuc);
            Console.ReadKey();

        }
    }
}
