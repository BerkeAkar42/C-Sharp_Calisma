using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotOrtGoreCiktiVerenProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Kullanıcıdan iki not girilmesi istenecek ve bu iki notun ortalaması alınarak belirlenen koşullara göre ekrana bir çıktı verecek.
            Not ortalaması 70'den büyük ise ekrana "İYİ" yazacak. 70'den küçük ise ekrana "KÖTÜ" yazacack. */

            int top = 0;
            int sayac = 0;


            while (sayac<2)
            {
                sayac++;
                Console.Write("Lütfen Notunuzu Giriniz: ");
                int x = Convert.ToInt32(Console.ReadLine());
                top += x; //top= top + x;
            }

            int ort = top / sayac;

            if (ort>=70)
            {
                Console.WriteLine("İYİ");
            }
            else
            {
                Console.WriteLine("KÖTÜ");
            }
            Console.ReadKey();

        }
    }
}
