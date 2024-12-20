using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcgeninUcuncuAcisiniBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden üçgenin iki açısını aldıktan sonra üçüncü açısını ekrana yazdıran; üçgenin iç açıları toplamı kuralına da uyup uymadığını kontrol eden program */

            int top = 0;

            Baslangic:
            for (int sayac=2; sayac>0; sayac--)
            {
                Console.Write("Açıyı Giriniz: ");
                int x = Convert.ToInt32(Console.ReadLine());

                top += x;
            }

            if (top<180)
            {
                top = 180 - top;
                Console.WriteLine("Üçgenin Üçüncü Açısı: " + top);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Üçgenin İç Açıları Kurallarına Uyan Değerler Girmediniz! Lütfen Tekrardan Giriniz.");
                top = 0;
                goto Baslangic;
            }

        }
    }
}
