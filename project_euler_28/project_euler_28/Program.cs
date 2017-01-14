using System;

namespace project_euler_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCells = 1001;
            int lastNumer = 1;
            int total = 1;
            for(int x = 1; x <= numberOfCells/2; x++)
            {
                for(int y = 0; y < 4; y++)
                {
                    total += lastNumer + 2 * x;
                    lastNumer = lastNumer + 2 * x;
                }
            }

            Console.WriteLine(total);
            Console.Read();
        }
    }
}
