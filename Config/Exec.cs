using LeetCodex.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodex.Config
{
    public class Exec
    {
        public void TwoSum() {
            Two_Sum1 two_Sum = new Two_Sum1();

            List<int> ls = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                ls.Add(i);
            }

            var num = ls.ToArray();

            int[] num2 = { 2, 11, 15, 7 };

            var returnValue = two_Sum.TwoSum(num2, 22);

            for (int i = 0; i < returnValue.Length; i++)
            {
                Console.Write($"[{returnValue[i]}]");
            }
        }

        public void RomanToInteger()
        {
            Roman_to_Integer.RomanToInt("MCMXCIV");
        }

    }
}
