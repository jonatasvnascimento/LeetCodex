using FizzWare.NBuilder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LeetCodex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Two_Sum1 two_Sum = new Two_Sum1();
            //var ls = Builder<Tmp>.CreateListOfSize(10000)
            //    .All()
            //    .With(c => c.valor = Faker.RandomNumber.Next(1, 100000000))
            //    .Build()
            //    .ToList()
            //    .Select(c => c.valor)
            //    .ToList();
            List<int> ls = new List<int>();
            for (int i = 0; i < 300000; i++)
            {
                ls.Add(i);
            }
            var num =  ls.ToArray();
            var returnValue = two_Sum.TwoSum(num, 500000);


            for (int i = 0; i < returnValue.Length; i++)
            {
                Console.Write($"[{returnValue[i]}]");
            }

            Console.WriteLine($"Tempo passado: {stopwatch.Elapsed}");
            stopwatch.Stop();
        }
    }

    public class Tmp
    {
        public int valor { get; set; }
    }
}
