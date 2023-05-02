using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodex.Easy
{
    public class Roman_to_Integer
    {
        public static int RomanToInt(string s)
        {
            Dictionary<string, int> NumRoman = new Dictionary<string, int>()
            {
                {"I",1},
                {"V",5},
                {"X",10},
                {"L",50},
                {"C",100},
                {"D",500},
                {"M",1000},
                
            };

            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                foreach (KeyValuePair<string, int> num in NumRoman)
                {
                    if (s[i].ToString() == num.Key)
                    {
                        count += num.Value;
                        Console.WriteLine(num.Key);
                    }
                }
            }

            Console.WriteLine(count);

            return 0;
        }
    }
}
