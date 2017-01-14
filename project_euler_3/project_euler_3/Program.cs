using System;

namespace project_euler_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const long OriginalNumber = 600851475143;
            long number = OriginalNumber;
            long hoogstePriemfactor = 0;


            long i = 2;
            while (true)
            {
                if (i > number / 2)
                {
                    hoogstePriemfactor = number;
                    break;
                }

                if (number % i == 0)
                {
                    hoogstePriemfactor = i;
                    number /= i;
                }
                else
                    i++;
            }

            Console.Out.WriteLine(hoogstePriemfactor);
            Console.In.ReadLine();
        }
    }
}
