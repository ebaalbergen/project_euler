using System;

namespace project_euler_6
{
    class Program
    {
        static void Main(string[] args)
        {
            long max = 100;

            long sumOfSquares = 0;
            long sum = 0;

            for (int x = 1; x <= max; x++)
            {
                sum += x;
                sumOfSquares += x * x;
            }
            long squareOfsum = sum * sum;
            Console.WriteLine(squareOfsum - sumOfSquares);
            Console.ReadLine();
        }
    }
}
