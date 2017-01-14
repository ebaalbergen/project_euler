using System;

namespace project_euler_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int number = 1; number <= 10000; number++)
            {
                int result = SumOfDivisors(number);
                if (result != number && SumOfDivisors(result) == number)
                    sum += number;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static int SumOfDivisors(int number)
        {
            int sum = 0;
            for(int x = 1; x < number / 2 + 1; x++)
            {
                if (number % x == 0)
                    sum += x;
            }

            return sum;
        }
    }
}
