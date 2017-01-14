using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = 1;
            sbyte[] getal = new sbyte[10];

            for (sbyte x = 0; x < 10; x++)
                getal[x] = x;

            printNumber(getal, true);

            while (numberOfNumbers < 1000000)
            {
                getal = add(getal);

                if (testNumberContainAllDigits(getal))
                {
                    numberOfNumbers++;
                    Console.WriteLine(numberOfNumbers);
                }
                //printNumber(getal);
            }
            printNumber(getal, true);
            Console.Read();
        }

        private static bool testNumberContainAllDigits(sbyte[] getal)
        {
            bool[] nums = new bool[10];
            for (int x = 0; x < 10; x++)
                nums[x] = false;

            foreach (sbyte num in getal)
            {
                if (nums[num] == true)
                    return false;
                else
                    nums[num] = true;
            }

            return true;
        }

        static sbyte[] add(sbyte[] getal1)
        {
            sbyte[] returnValue = new sbyte[getal1.Length];
            sbyte carry = 1;

            for (int x = getal1.Length - 1; x >= 0; x--)
            {
                returnValue[x] = (sbyte)(getal1[x] + carry);

                if (returnValue[x] > 9)
                {
                    sbyte temp = returnValue[x];
                    returnValue[x] = (sbyte)(temp % 10);
                    carry = (sbyte)((temp - returnValue[x]) / 10);
                }
                else
                    carry = 0;

            }
            return returnValue;
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
    }
}
