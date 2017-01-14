using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_17
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte[] singleDigit = {0, 3, 3, 5, 4, 4, 3, 5, 5, 4, 3, 6, 6, 8, 8, 7, 7, 9, 8, 8 };
            sbyte[] tensDigit = {0, 3, 6, 6, 5, 5, 5, 7, 6, 6 };
            sbyte hundredDigit = 7;
            sbyte thousendDigit = 8;

            int total = 0;
            for (int x = 1; x < 1000; x++)
            {
                sbyte single = (sbyte)(x % 10);
                sbyte tens = (sbyte)(((x % 100) - single) / 10);
                sbyte hundreds = (sbyte)(((x % 1000) - single - tens) / 100);

                if (hundreds != 0)
                {
                    total += singleDigit[hundreds] + hundredDigit;
                    if (tens != 0 || single != 0)
                        total += 3;
                }
                if (tens == 0 || tens == 1)
                    total += singleDigit[tens * 10 + single];
                else
                    total += tensDigit[tens] + singleDigit[single];
            }

            total += singleDigit[1] + thousendDigit;
            Console.WriteLine(total);
            Console.Read();
        }
    }
}
