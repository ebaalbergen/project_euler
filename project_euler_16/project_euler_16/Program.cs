using System;

namespace project_euler_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getal = new int[1000];
            for(int x = 0; x < 999; x++)
            {
                getal[x] = 0;
            }

            getal[999] = 1;

            for(int x = 0; x < 1000; x++)
            {
                bool carry = false;

                for (int y = 999; y > 0; y--)
                {
                    getal[y] *= 2;

                    if (carry)
                        getal[y]++;

                    if (getal[y] > 9)
                    {
                        carry = true;
                        getal[y] %= 10;
                    }
                    else
                        carry = false;
                }
            }

            int sum = 0;
            foreach(int number in getal)
                sum += number;

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
