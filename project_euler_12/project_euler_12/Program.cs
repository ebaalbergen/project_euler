using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_12
{
    class Program
    {
        static void Main(string[] args)
        {
            long triangle = 0;
            long i = 0;

            int maxNumOfDiv = 0;

            while (true)
            {
                int numOfDiv = GetNumberOfDivisors(triangle);
                Console.WriteLine(maxNumOfDiv);
                if (numOfDiv > 500)
                    break;
                if (numOfDiv > maxNumOfDiv)
                    maxNumOfDiv = numOfDiv;
                i++;
                triangle += i;
            }
            Console.WriteLine(triangle);
            Console.Read();
        }

        static int GetNumberOfDivisors(long number)
        {
            int numberOfDivisors = 1;
            for(long x = 1; x <= number / 2 + 1; x++)
            {
                if (number % x == 0)
                    numberOfDivisors++;
            }
            return numberOfDivisors;
        }
    }
}
