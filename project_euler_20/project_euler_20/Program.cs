using System;

namespace project_euler_20
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxNumberOfDigits = 1000;
            const sbyte factor = 100;

            int[] number = new int[maxNumberOfDigits];
            for (int x = 0; x < number.Length; x++)
            {
                number[x] = 0;
            }
            number[number.Length - 1] = 1;
            
            factorial(ref number, factor);

            int sum = 0;
            foreach(int getal in number)
            {
                sum += getal;
            }
            Console.Write(sum);
            Console.Read();
        }

        private static void factorial(ref int[] number, sbyte factorial)
        {
            for (sbyte x = 1; x <= factorial; x++)
            {
                for (int y = 0; y < number.Length; y++)
                {
                    number[y] *= x;
                }

                for (int y = number.Length - 1; y > 0; y--)
                {
                    if (number[y] > 9)
                    {
                        int temp = number[y];
                        number[y] = (temp % 10);
                        number[y - 1] += ((temp - number[y]) / 10);
                    }
                }
            }
        }

        static void printNumber(sbyte[] number, bool printZero = false)
        {
            string print = "";
            for (int x = 0; x < number.Length; x++)
            {
                if (number[x] == 0 && printZero == false && print.Length == 0)
                    continue;
                print = print + number[x].ToString();
            }

            Console.WriteLine(print);
        }

        static void printNumber(int[] number, bool printZero = false)
        {
            string print = "";
            for (int x = 0; x < number.Length; x++)
            {
                if (number[x] == 0 && printZero == false && print.Length == 0)
                    continue;
                print = print + number[x].ToString();
            }

            Console.WriteLine(print);
        }
    }
}
