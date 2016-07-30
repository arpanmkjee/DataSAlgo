using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1A1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //StressTest();
            var no = long.Parse(Console.ReadLine());
            long[] nos = Array.ConvertAll(Console.ReadLine().Split(' '), s => long.Parse(s));
            Console.WriteLine(MaxPairwiseProduct(no, nos).ToString());
        }

        /// <summary>
        /// This method will be used for stress testing by generating random numbers and comparing output of two solutions
        /// </summary>
        public static void StressTest()
        {
            Random rnd = new Random();
            while (true)
            {
                int n = rnd.Next(1, 30);
                Console.WriteLine(n);
                long[] a = new long[n];
                for (int i = 0; i < n; ++i)
                {
                    a[i] = rnd.Next(0,1000);
                }
                for (int i = 0; i < n; ++i)
                {
                    Console.Write(a[i] + " ");
                }
                Console.Write("\n");
                long res1 = MaxPairwiseProduct2(n,a);
                long res2 = MaxPairwiseProduct(n,a);
                if (res1 != res2)
                {
                    Console.Write("Wrong answer: " + res1 + ' ' + res2 + "\n");
                    break;
                }
                else
                {
                    Console.Write("OK\n");
                }
            }
        }

        public static long MaxPairwiseProduct(long no, long[] nos)
        {
            long output = 0, no1 = 0, no2 = 0;
            for (var i = 0; i < no; i++)
            {
                if (no1 == 0)
                {
                    no1 = nos[i];
                    continue;
                }
                if (no2 == 0)
                {
                    if (nos[i] > no1)
                    {
                        no2 = no1;
                        no1 = nos[i];
                    }
                    else
                        no2 = nos[i];
                    continue;
                }
                if (nos[i] > no2)
                {
                    if (nos[i] > no1)
                    {
                        no2 = no1;
                        no1 = nos[i];
                        continue;
                    }
                    else
                    {
                        no2 = nos[i];
                        continue;
                    }
                }
            }

            output = no1 * no2;
            return output;
        }

        /// <summary>
        /// This is a brute force attack method. This should fail the time complexity requirements but will be usefull for stress testing.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static long MaxPairwiseProduct2(long n, long[] numbers)
        {
            long result = 0;
            for (long i = 0; i < n; ++i)
            {
                for (long j = i + 1; j < n; ++j)
                {
                    if (numbers[i] * numbers[j] > result)
                    {
                        result = numbers[i] * numbers[j];
                    }
                }
            }
            return result;
        }
    }
}
