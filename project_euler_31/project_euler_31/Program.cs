using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_31
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> possiblePrimes = new List<int>();
            short[] number = new short[6];
            for (int x = 0; x < number.Length; x++)
                number[x] = 0;

            number[5] = 1;
            while (!(number[1] == 9 && number[2] == 9 && number[3] == 9 && number[4] == 9 && number[5] == 9))
            {
                for(int x = 5; x >= 0; x--)
                {
                    if (number[x] == 9 && x != 0)
                    {
                        if (number[x - 1] != 9)
                            number[x - 1] += 2;
                        else
                        {
                            number[x - 1] = 1;
                            if (x < 2)
                                break;
                            else
                                number[x - 2] += 2;
                        }
                    }   

                    number[x] += 2;
                }
            }
        }

        static bool IsPrime(int number)
        {
            int upperBound = (int) Math.Sqrt(number) + 1;
            for(int x = 2; x < upperBound; x++)
                if (number % x != 0)
                    return false;
            return true;
        }
    }
}
