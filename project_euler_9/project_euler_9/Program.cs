using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 1000; a++)
            {
                for (int b = 0; b < 1000; b++)
                {
                    for (int c = 0; c < 1000; c++)
                    {
                        if((a < b) && b < c)
                        {
                            if(a + b + c == 1000)
                            {
                                if (testPythago(a, b, c))
                                    Console.WriteLine("A = " + a + " B = " + b + " C = " + c);
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }

        static bool testPythago(int a, int b, int c)
        {
            if (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) == c)
                return true;
            else
                return false;
        }
    }
}
