using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD
{
    internal class Program
    {
        public static int[] Association(int[][] allarrays)
        {
            int index = 0;
            int sum = 0;

            for (int i = 0; i < allarrays.Length; i++)
            {
                sum += allarrays[i].Length;
            }

            int[] allarraysline = new int[sum];

            for (int i = 0; i < allarrays.Length; i++)
            {
                for(int j = 0; j < allarrays[i].Length; j++)
                {
                    allarraysline[index] = allarrays[i][j];
                    index++;
                }
            }

            return allarraysline;
        }

        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3 };
            int[] b = new int[] { 2, 4, 24, 25 };
            int[] c = new int[] { 1, 4, 5, 6, 7, 89, 99, 131, 213 };
            int[][] allarrays = new int[3][];

            allarrays[0] = a;
            allarrays[1] = b;
            allarrays[2] = c;

            int[] finalarr;
            finalarr = Association(allarrays);
            Array.Sort(finalarr);

            foreach (int i in finalarr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            List<int> numbers = new List<int> { 3, 30, 34, 5, 9 };
            string largestnum = LargestNumber(numbers);
            Console.WriteLine(largestnum);
        }
        public static string LargestNumber(List<int> nums)
        {
            List<string> strings = nums.Select(n => n.ToString()).ToList();
            strings.Sort((a, b) => (b + a).CompareTo(a + b));
            return string.Concat(strings);
        }
    }
}
