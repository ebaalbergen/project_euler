using System;

namespace project_Euler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            const int max = 1000;

            for (i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            Console.Out.WriteLine("Antwoord: " + sum);
            Console.In.ReadLine();
        }
    }
}
