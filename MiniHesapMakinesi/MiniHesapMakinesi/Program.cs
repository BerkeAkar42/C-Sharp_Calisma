using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniHesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Kullanıcıdan iki tane sayı alıp bu sayıları dört işlem ile hesaba dökebilen mini bir hesap makinesi programı */


            Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Toplama: +");
            Console.WriteLine("Çıkarma: -");
            Console.WriteLine("Çarpma: *"); 
            Console.WriteLine("Bölme: /");

            Console.WriteLine();

            Console.Write("Yapmak İstediğiniz İşlemi Seçiniz: ");
            string islem = Console.ReadLine().ToString();


            islembolumu:
            double sonuc = 0;

            if (islem == "+")
            {
                sonuc = s1 + s2;
            }
            else if (islem == "-")
            {
                sonuc = s1 - s2;
            }
            else if (islem == "*")
            {
                sonuc = s1 * s2;
            }
            else if (islem == "/")
            {
                sonuc = s1 / s2;
            }
            else
            {
                Console.WriteLine("Yapmak İstediğiniz İşlemi Yanlış Girdiniz! Lütfen Tekrardan Deneyiniz.");
                goto islembolumu;
            }


            Console.WriteLine("İşlemin Sonucu: " + sonuc.ToString());

            Console.ReadKey();

        }
    }
}
