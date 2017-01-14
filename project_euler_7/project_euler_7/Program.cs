using System;

namespace project_euler_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            int numOfPrimes = 1;
            int maxPrime = 0;

            while (numOfPrimes <= 10001)
            {
                bool prime = CheckIfPrime(i);
                if (prime)
                {
                    Console.WriteLine(i);
                    numOfPrimes++;
                    maxPrime = i;
                }
                i++;
            }
            Console.WriteLine(maxPrime);
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
