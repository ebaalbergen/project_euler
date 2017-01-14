using System;

namespace project_euler_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 1;
            for (int i = 1; i < 20; i++)
            {
                res = kgv(i, res);
            }
            Console.WriteLine(res);
            Console.Read();
        }

        static int kgv(int x, int y)
        {
            return Math.Abs(x * y)/ggd(x, y);
        }

        static int ggd(int x, int y)
        {
            if (x == y)
                return x;
            int a;
            int b;

            if (x < y)
            {
                a = y;
                b = x;
            }
            else
            {
                a = x;
                b = y;
            }

            int nieuweA = a;

            while (nieuweA != 0 && nieuweA > b)
            {
                nieuweA -= b;
            }

            if (nieuweA == 0)
            {
                return b;
            }
            else
            {
                return ggd(b, nieuweA);
            }
        }
    }
}
