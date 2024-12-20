using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirIlaYuzArasindakiCiftSayilarinToplaminiBulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1 ila 100 arasındaki çift sayıların toplamını bulup ekrana yazdıran program */

            int top = 0;

            for (int sayac=1; sayac<101; sayac++)
            {

                if (sayac%2==0)
                {
                    top += sayac;
                }

            }

            Console.WriteLine(top);
            Console.ReadKey();

        }
    }
}
