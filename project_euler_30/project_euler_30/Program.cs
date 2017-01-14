using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfNumbers = 0;
            for(int x = 2; x < 354294; x++)
            {
                int y = x;
                int sumOfDigits = (int) Math.Pow(y % 10, 5);

                while((y /= 10) > 0)
                {
                    sumOfDigits += (int) Math.Pow(y % 10, 5);
                }

                if (sumOfDigits == x)
                {
                    sumOfNumbers += x;
                    Console.WriteLine(x);
                }

            }
            Console.WriteLine(sumOfNumbers);
            Console.Read();
        }
    }
}
