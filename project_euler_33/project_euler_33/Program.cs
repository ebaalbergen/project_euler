using System;

namespace project_euler_33
{
    class Project_euler_33
    {
        public static void Main()
        {
            int noemer = 1;
            int teller = 1;
            for(sbyte a = 10; a < 100; a++)
            {
                for(sbyte b = 10; b < 100; b++)
                {
                    if (a % 10 == 0 || b % 10 == 0 || a == b || (float) a / b > 1)
                        continue;
                    if(a % 10 == b % 10)
                    {
                        if ((float)a / b == (float)(a / 10) / (b / 10))
                        {
                            teller *= a / 10;
                            noemer *= b / 10;
                            Console.WriteLine(a + "/" + b + "=" + a / 10 + "/" + b / 10);
                        }
                    } else if(a % 10 == b / 10)
                    {
                        if ((float)a / b == (float)(a / 10) / (b % 10))
                        {
                            teller *= a / 10;
                            noemer *= b % 10;
                            Console.WriteLine(a + "/" + b + "=" + a / 10 + "/" + b % 10);
                        }
                    } else if(a / 10 == b % 10)
                    {
                        if ((float)a / b == (float)(a % 10) / (b / 10))
                        {
                            teller *= a % 10;
                            noemer *= b / 10;
                            Console.WriteLine(a + "/" + b + "=" + a % 10 + "/" + b / 10);
                        }
                    } else if(a / 10 == b / 10)
                    {
                        if ((float)a / b == (float)(a % 10) / (b % 10))
                        {
                            teller *= a % 10;
                            noemer *= b % 10;
                            Console.WriteLine(a + "/" + b + "=" + a % 10 + "/" + b % 10);
                        }
                    }
                }
            }
            while(GGD(teller, noemer) != 1)
            {
                for(int x = 2; x < noemer; x++)
                {
                    while(teller % x == 0 && noemer % x == 0)
                    {
                        teller /= x;
                        noemer /= x;
                    }
                }
            }

            Console.WriteLine(teller + "/" + noemer);
            Console.Read();
        }

        static int GGD(int a, int b)
        {
            return b == 0 ? a : GGD(b, a % b);
        }
    }
}