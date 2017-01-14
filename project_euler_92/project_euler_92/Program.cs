using System;

namespace project_euler_92
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 0;
            for(long x = 1; x < 10000000; x++)
            {
                Console.WriteLine(x + "----->" + chain(x));
                if (chain(x))
                    number++;
            }
            Console.WriteLine(number);
            Console.ReadLine();
        }

        static bool chain(long start)
        {
            long number = start;
            while (true)
            {
                number = getNextNumber(number);

                if (number == 89)
                    return true;
                if (number == 1)
                    return false;
            }
        }

        static long getNextNumber(long number)
        {
            long value = 0;
            string tempString = number.ToString();
            foreach(char letter in tempString)
            {
                value += ((int) Char.GetNumericValue(letter) * (int)Char.GetNumericValue(letter));
            }
            return value;
        }
    }
}
