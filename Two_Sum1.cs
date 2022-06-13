using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodex
{
    public class Two_Sum1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] returnValue = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        returnValue[0] = i;
                        returnValue[1] = j;
                    }
                }
            }
            return returnValue;
        }
    }
}
