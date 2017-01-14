using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] sums = new int[25602];
            int sumNotConsistingFromAbundent = 0;
            int numOfSums = 0;

            {
                ArrayList abundentNumbers = new ArrayList();
                
                for (int x = 1; x <= 14062; x++)
                {
                    if (NumberAbundent(x))
                        abundentNumbers.Add(x);
                }

                foreach (int num in abundentNumbers)
                {
                    foreach (int num2 in abundentNumbers)
                    {
                        if (num + num2 < 28123)
                        {
                            if (!sums.Contains(num + num2))
                            {
                                Console.WriteLine(num + "    " + num2);
                                sums[numOfSums] = num + num2;
                                numOfSums++;
                            }
                        }

                        if (numOfSums >= 28123)
                            break;
                    }
                }
            }
            Console.Write(numOfSums);
            for(int x = 0; x <= numOfSums; x++)
            {
                Console.WriteLine(x);
                if (!sums.Contains(x))
                    sumNotConsistingFromAbundent += x;
            }

            Console.WriteLine(sumNotConsistingFromAbundent);*/

            ArrayList numbers = new ArrayList();
            ArrayList abundentNumbers = new ArrayList();

            for (int x = 1; x < 28123; x++)
                numbers.Add(x);

            for (int x = 1; x < 14062; x++)
            {
                Console.WriteLine(x);
                if (NumberAbundent(x))
                {
                    abundentNumbers.Add(x);

                    int multible = 0;
                    multible = 2 * x;
                    int position = numbers.IndexOf(multible);
                    if (position >= 0)
                        numbers.RemoveAt(position);
                }
            }

            int[] sums = new int[28123];
            int numOfSums = 0;

            foreach (int abundent1 in abundentNumbers)
            {
                foreach (int abundent2 in abundentNumbers)
                {
                    Console.WriteLine(abundent1 + "   " + abundent2);
                    int sum = abundent1 + abundent2;
                    
                    if (sum > 28123 || abundent1 == abundent2)
                        continue;
                    else if (sums.Contains(sum))
                        continue;
                    else
                    {
                        sums[numOfSums] = sum;
                        numOfSums++;
                    }
                    int position = numbers.IndexOf(sum);
                    if (position >= 0)
                        numbers.RemoveAt(position);
                }
            }


            int total = 0;
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                total += number;
            }

            Console.WriteLine(total);
            Console.ReadLine();
        }

        static bool NumberAbundent(int number)
        {
            int sumOfDivisors = 0;

            for (int x = 1; x < number / 2 + 1; x++)
            {
                if (number % x == 0)
                    sumOfDivisors += x;
            }

            return (sumOfDivisors > number) ? true: false;
        }
    }
}
