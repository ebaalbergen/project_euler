using System;

namespace project_euler_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoogstePalindrome = 0;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    if (TestPalindrome(i * j))
                    {
                        if(i * j > hoogstePalindrome)
                            hoogstePalindrome = i * j;
                    }
                }
            }

            Console.WriteLine(hoogstePalindrome);
            Console.ReadLine();
        }

        static bool TestPalindrome(int number)
        {
            Char[] numberArray = number.ToString().ToCharArray();
            if (numberArray.Length == 1)
            {
                return true;
            }
            int i = 0;
            while (true)
            {
                if (numberArray[i] != numberArray[numberArray.Length - 1 - i])
                    return false;
                else
                {
                    i++;
                    if (i == numberArray.Length - i || i == numberArray.Length - 1 - i)
                    {
                        return true;
                    }
                }
            }
        }
    }
}
