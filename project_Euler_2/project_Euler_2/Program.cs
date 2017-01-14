using System;

namespace project_Euler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint sum = 0;
            for (int i = 1; Fibonacci(i) < 4000000; i++)
            {
                int res = Fibonacci(i);
                if (res % 2 == 0)
                {
                    sum += (uint) res;
                }
            }

            Console.Out.WriteLine(sum);
            Console.In.ReadLine();
        }

        static private int Fibonacci(int input)
        {
            if (input == 1 || input == 2)
                return 1;
            else
                return Fibonacci(input - 1) + Fibonacci(input - 2);
        }
    }
}
