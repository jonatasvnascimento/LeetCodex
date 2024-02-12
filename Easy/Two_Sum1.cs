using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodex.Easy
{
    public class Two_Sum1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> resultDictionary = new();

            if (nums == null || nums.Length < 2)
            {
                return Array.Empty<int>();
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (resultDictionary.TryGetValue(complement, out int index)) 
                    return new[] { index, i };
                resultDictionary[nums[i]] = i;
            }

            return Array.Empty<int>();
        }
    }
}
