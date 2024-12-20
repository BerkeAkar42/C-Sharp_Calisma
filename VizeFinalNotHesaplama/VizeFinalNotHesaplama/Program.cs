using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeFinalNotHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* klavyeden alınan vize ve final notlarına göre ortama hesaplayan; ortalaması 45 ve üstü ise ekranda "GEÇTİ" değilse "KALDI" yazan program */
            //Vize %40, Final %60'ı alınacaktır!


            Console.Write("Vize Notunuzu Giriniz: ");
            double not1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final Notunuzu Giriniz: ");
            double not2 = Convert.ToInt32(Console.ReadLine());

            not1 *= 0.4;
            not2 *= 0.6;

            int ort = Convert.ToInt32(not1 + not2);

            Console.WriteLine();

            Console.WriteLine("Vize Notu (%40'ı): " + not1);
            Console.WriteLine("Final Notu (%60'ı): " + not2);
            Console.WriteLine("Not Ortalamanız: " + ort);

            Console.WriteLine();

            if (ort >= 45)
            {
                Console.WriteLine("GEÇTİ");
            }
            else
            {
                Console.WriteLine("KALDI");
            }

            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
