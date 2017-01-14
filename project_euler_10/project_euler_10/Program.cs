using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            int maxPrime = 0;
            long sum = 2;

            while (true)
            {
                if (i < 2000000)
                {

                    bool prime = CheckIfPrime(i);
                    if (prime)
                    {
                        Console.WriteLine(i);
                        maxPrime = i;
                        sum += i;
                    }
                    i++;
                } else
                    break;
            }
            Console.WriteLine(sum);
            Console.Read();
        }

        static bool CheckIfPrime(int n) //to check if the random number generated is prime
        {
            var isPrime = true;
            var sqrt = Math.Sqrt(n);
            for (var i = 2; i <= sqrt; i++)
                if ((n % i) == 0) isPrime = false;
            return isPrime;
        }
    }
}
