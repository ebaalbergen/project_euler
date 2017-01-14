using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_40
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for(int x = 1; x <= 1000000; x *= 10)
                result *= GetChampernowneDigit(x);
            Console.WriteLine(result);
            Console.Read();
        }

        static sbyte GetChampernowneDigit(int digit)
        {
            int number = 1;
            int counter = 1;
            while (counter < digit)
            {
                number++;
                counter += GetNumberOfDigits(number);
            }
            int difference = counter - digit;
            while(difference != 0)
            {
                difference--;
                number /= 10;
            }
            return Convert.ToSByte(number % 10);
        }

        static sbyte GetNumberOfDigits(int number)
        {
            sbyte returnValue = 1;
            while(number / 10 != 0)
            {
                number /= 10;
                returnValue++;
            }
            return returnValue;
        }
    }
}
