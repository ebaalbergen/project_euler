using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLength = 0;
            int maxLengthStep = 0;
            for(int x = 1; x < 1000000; x++)
            {
                Console.WriteLine(x + "     " + maxLength);
                if (Collatz(x) > maxLength)
                {
                    maxLength = Collatz(x);
                    maxLengthStep = x;
                }
                    
            }

            Console.WriteLine(maxLengthStep);
            Console.ReadLine();
        }

        static int Collatz(long number)
        {
            int length = 0;
            while (number != 1)
            {
                if (number % 2 == 0)
                    number = number / 2;
                else
                    number = 3 * number + 1;
                length++;
            }
            return length;
        }
    }
}
