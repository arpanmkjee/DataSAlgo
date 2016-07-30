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
            var no = long.Parse(Console.ReadLine());
            long[] nos = Array.ConvertAll(Console.ReadLine().Split(' '), s => long.Parse(s));
            Console.WriteLine(MaxPairwiseProduct(no, nos).ToString());
        }

        public static long MaxPairwiseProduct(long no, long[] nos)
        {
            long output = 0;
            return output;
        }

    }
}
