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
                {"I",1},{"V",5},{"X",10},{"L",50},{"C",100},{"D",500},{"M",1000},
            };
            int Numeral = 0;
            int prevValue = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int currentValue = NumRoman[s[i].ToString()];

                if (currentValue < prevValue)
                {
                    Numeral -= currentValue;
                }
                else
                {
                    Numeral += currentValue;
                }

                prevValue = currentValue;
            }
            return Numeral;
        }
    }
}
