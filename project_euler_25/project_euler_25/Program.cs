using System;

namespace project_euler_25
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxNumberOfDigits = 1000;

            sbyte[] getal = new sbyte[maxNumberOfDigits];
            sbyte[] vorigGetal = new sbyte[maxNumberOfDigits];
            int fibonacciIndex = 0;

            for(int x = 0; x < getal.Length; x++)
            {
                getal[x] = 0;
                vorigGetal[x] = 0;
            }

            while(getal[0] == 0)
            {
                if (fibonacciIndex != 0)
                {
                    sbyte[] temp = vorigGetal;
                    vorigGetal = getal;
                    getal = add(vorigGetal, temp);
                }
                else
                    getal[getal.Length - 1] = 1;

                fibonacciIndex++;
            }

            Console.WriteLine(fibonacciIndex);
            Console.Read();
        }

        static sbyte[] add(sbyte[] getal1, sbyte[] getal2)
        {
            if (getal1.Length == getal2.Length)
            {
                sbyte[] returnValue = new sbyte[getal1.Length];
                sbyte carry = 0;

                for (int x = getal1.Length - 1; x >= 0; x--)
                {
                    returnValue[x] = (sbyte)(getal1[x] + getal2[x] + carry);

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
            else
                throw new Exception("The numbers are not the same size!");
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
