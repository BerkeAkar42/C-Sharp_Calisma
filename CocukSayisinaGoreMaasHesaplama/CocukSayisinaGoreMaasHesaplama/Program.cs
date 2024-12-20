using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocukSayisinaGoreMaasHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Klavyeden maaş aldıktan sonra kullanıcının çocuk sayısına göre belirli kriterlerde artış yapılarak yeni maaşını ekranda yazdıran program */
            // 1 çocuk: %5, 2 çocuk %10, 3<= çocuk: %15

            double yenipara = 0;

            Console.Write("Maaşınızı Giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Çocuk Sayısını Giriniz: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (c==0)
            {
                yenipara = m;
                Console.WriteLine();
                Console.WriteLine("Yardım Miktarı : 0");
                Console.WriteLine("Yeni Maaşınız: " + yenipara);
                Console.ReadKey();
            }
            else if (c==1)
            {
                yenipara = m * 0.05;
                Console.WriteLine();
                Console.WriteLine("Yardım Miktarı: " + yenipara);
                yenipara += m;
                Console.WriteLine("Yeni Maaşınız: " + yenipara);
                Console.ReadKey();
            }
            else if (c==2)
            {
                yenipara = m * 0.1;
                Console.WriteLine();
                Console.WriteLine("Yardım Miktarı: " + yenipara);
                yenipara += m;
                Console.WriteLine("Yeni Maaşınız: " + yenipara);
                Console.ReadKey();
            }
            else if (c>=3)
            {
                yenipara = m * 0.15;
                Console.WriteLine();
                Console.WriteLine("Yardım Miktarı: " + yenipara);
                yenipara += m;
                Console.WriteLine("Yeni Maaşınız: " + yenipara);
                Console.ReadKey();
            }
        }
    }
}
