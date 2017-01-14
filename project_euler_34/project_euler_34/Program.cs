using System;

namespace project_euler_34
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (long x = 3; x < 9999999; x++)
            {
                long tempValue = x;
                int tempsum = 0;
                while (tempValue != 0)
                {
                    tempsum += Factorial(Convert.ToInt32(tempValue % 10));
                    tempValue /= 10;
                }

                if (tempsum == x)
                {
                    sum += tempsum;
                    Console.WriteLine(x);
                }
            }
            Console.WriteLine("Done!");
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static int Factorial(int number)
        {
            if (number <= 1)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}
