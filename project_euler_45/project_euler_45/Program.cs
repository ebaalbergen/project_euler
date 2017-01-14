using System;

namespace project_euler_45
{
    class Program
    {
        static void Main(string[] args)
        {
            long triangle = 286;

            //Console.WriteLine(IsHexagonalNumber(1533776805));
            while (true)
            {
                long result = TriangleNumber(triangle);
                if (IsPentagonalNumber(result))
                    if (IsHexagonalNumber(result))
                        break;
                triangle++;
                Console.WriteLine(result);

            }

            Console.WriteLine(TriangleNumber(triangle));
            Console.Read();
        }

        static long TriangleNumber(long n)
        {
            return (n * n + n) / 2;
        }

        static bool IsPentagonalNumber(long x)
        {
            double n = (1 + Math.Sqrt(1 + 24 * x)) / 6;
            
            if (n % 1 == 0)
                return true;
            return false;
        }

        static bool IsHexagonalNumber(long x)
        {
            double n = (1 + Math.Sqrt(1 + 8 * x)) / 4;

            if (n % 1 == 0)
                return true;
            return false;
        }

    }
}
