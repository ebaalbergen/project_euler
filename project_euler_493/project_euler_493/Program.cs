using System;
using System.Collections;

namespace project_euler_493
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfBallsPerColour = 10;
            sbyte numberOfColours = 7;
            sbyte codeLength = 5;

            ArrayList colours = new ArrayList();

            {
                sbyte[] lastNumber = new sbyte[codeLength];
                sbyte[] code = new sbyte[codeLength];
                for (int x = 0; x < lastNumber.Length; x++)
                {
                    lastNumber[x] = (sbyte)(numberOfColours - 1);
                    code[x] = 0;
                }
                
                while (!equals(code, lastNumber))
                {
                    Tester tester = new Tester(codeLength, numberOfColours, numberOfBallsPerColour);

                    if (tester.setCode(code).testNumberPossible())
                        colours.Add(tester.getNumberOfColours());

                    printNumber(code, true);
                    add(ref code, numberOfColours);
                }
            }

            double average = 0.0;

            {
                long sum = 0;
                foreach(int colour in colours)
                    sum += colour;

                average = sum / (double)colours.Count;
            }

            Console.Write(average);
            Console.Read();
        }

        static void add( ref sbyte[] getal, sbyte maxNumber)
        {
            sbyte carry = 1;
            for (int x = getal.Length - 1; x >= 0; x--)
            {
                getal[x] = (sbyte)(getal[x] + carry);

                if (getal[x] >= maxNumber)
                {
                    sbyte temp = getal[x];
                    getal[x] = (sbyte)(temp % maxNumber + 1);
                    carry = (sbyte)((temp - getal[x]) / maxNumber + 1);
                }
                else
                    carry = 0;

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

        static bool equals(sbyte[] number1, sbyte[] number2)
        {
            if (number1.Length != number2.Length)
                return false;
            else
                for(int x = 0; x < number1.Length; x++)
                    if (number1[x] != number2[x])
                        return false;
            return true;
        }
    }
}
