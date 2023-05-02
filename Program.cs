using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using LeetCodex.Config;
using LeetCodex.Easy;

namespace LeetCodex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instacia das execuções dos problemas
            Exec exec = new Exec();

            //Verificação de tempo de execução do problema
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            exec.TwoSum();

            Console.WriteLine($"Tempo passado: {stopwatch.Elapsed}");
            stopwatch.Stop();
        }
    }

    public class Tmp
    {
        public int valor { get; set; }
    }
}
