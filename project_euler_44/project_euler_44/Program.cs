using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_44
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static bool IsPentagonalNumber(long x)
        {
            double n = (1 + Math.Sqrt(1 + 24 * x)) / 6;

            if (n % 1 == 0)
                return true;
            return false;
        }
    }
}
