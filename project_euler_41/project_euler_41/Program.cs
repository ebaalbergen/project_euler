using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(IsPandigital(2143));
            Console.Read();
        }

        static bool IsPandigital(int number)
        {
            bool[] numbers = new bool[10];
            for (int x = 0; x < numbers.Length; x++)
                numbers[x] = false;

            int numberOfNumbers = 1;

            while (number / 10 != 0)
            {
                numberOfNumbers++;
                int index = (number % 10) == 0? 9: (number % 10) - 1;
                numbers[number % 10] = true;
                number /= 10;
            }

            for(int x = 0; x < numbers.Length; x++)
            {
                if (x < numberOfNumbers && !numbers[x] || x > numberOfNumbers && numbers[x])
                    return false;
            }
            return true;
        }
    }
}
