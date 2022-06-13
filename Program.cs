using System;
using System.Diagnostics;

namespace LeetCodex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Two_Sum1 two_Sum = new Two_Sum1();
            int[] num = { 3, 3 };
            var returnValue = two_Sum.TwoSum(num, 6);


            for (int i = 0; i < returnValue.Length; i++)
            {
                Console.Write($"[{returnValue[i]}]");
            }

            Console.WriteLine($"Tempo passado: {stopwatch.Elapsed}");
            stopwatch.Stop();
        }
    }
}
