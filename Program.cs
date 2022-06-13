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
            int[] num = { 2, 7, 11, 15 };
            var returnValue = two_Sum.TwoSum(num, 9);


            foreach (var item in returnValue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Tempo passado: {stopwatch.Elapsed}");
            stopwatch.Stop();
        }
    }
}
