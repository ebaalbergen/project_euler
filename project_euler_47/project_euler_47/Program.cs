using System;

namespace project_euler_47
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int startingPoint = 210;
            while (true)
            {
                startingPoint += 3;
                if (GetNumberOfPrimeFactors(startingPoint) == 4)
                {
                    if (GetNumberOfPrimeFactors(startingPoint + 1) == 4)
                    {
                        if(GetNumberOfPrimeFactors(startingPoint - 1) == 4)
                        {
                            if (GetNumberOfPrimeFactors(startingPoint - 2) == 4)
                            {
                                result = startingPoint - 2;
                                break;
                            }
                            else if (GetNumberOfPrimeFactors(startingPoint + 2) == 4)
                            {
                                result = startingPoint - 1;
                                break;
                            }
                        } else if(GetNumberOfPrimeFactors(startingPoint + 2) == 4 && GetNumberOfPrimeFactors(startingPoint + 3) == 4)
                        {
                            result = startingPoint;
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(startingPoint);
                }
            }
            Console.WriteLine("");
            Console.WriteLine(result);
            Console.Read();
        }

        static int GetNumberOfPrimeFactors(int n)
        {
            int result = 0;
            int newN = n;
            for (int x = 2; x < Math.Sqrt(n); x++)
            {
                if(IsPrime(x))
                {
                    if(newN % x == 0)
                    {
                        result += 1;
                        while (newN % x == 0)
                        {
                            newN /= x;
                        }
                    }
                }
                if (newN == 1)
                    break;
            }
            if (newN != 1)
                result++;
            return result;
        }

        static bool IsPrime(int n)
        {
            if (n <= 2 && n > 0)
                return true;
            for (int x = 2; x <= Math.Sqrt(n); x++)
                if (n % x == 0)
                    return false;
            return true;
        }
    }
}
