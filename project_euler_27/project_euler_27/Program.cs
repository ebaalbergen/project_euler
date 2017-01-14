using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int highestA = 0, highestB = 0, maxNumberPrimes = 0;
            ArrayList priemGetallen = new ArrayList();
            for(int x = 0; x <= 1000; x++)
            {
                if (IsPrime(x))
                    priemGetallen.Add(x);
            }

            foreach (int b in priemGetallen)
            {
                for(int a = -999; a < 1000; a++)
                {
                    Console.WriteLine(a + " " + b);
                    if(GetNumberOfPrimesOfN(a, b) > maxNumberPrimes)
                    {
                        highestA = a;
                        highestB = b;
                        maxNumberPrimes = GetNumberOfPrimesOfN(a, b);
                    }
                }
            }
            //Console.WriteLine(GetNumberOfPrimesOfN(1, 41));
            Console.WriteLine(highestA * highestB);
            Console.WriteLine("n^2 + " + highestA + "n + " + highestB);
            Console.WriteLine(GetNumberOfPrimesOfN(highestA, highestB));
            Console.Read();
        }

        static bool IsPrime(int n)
        {
            if (!(n > 0))
                return false;
            if (n <= 2)
                return true;
            for (int x = 2; x <= Math.Sqrt(n); x++)
                if (n % x == 0)
                    return false;
            return true;
        }

        static int GetNumberOfPrimesOfN(int a, int b)
        {
            int n = 0;
            while (IsPrime(n*n+a*n+b))
            {
                n++;
            }
            return n;
        }
    }
}
