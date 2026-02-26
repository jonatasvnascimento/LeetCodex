namespace LeetCodex.Easy;

/// <summary>
/// LeetCode #1 - Two Sum (Easy)
/// https://leetcode.com/problems/two-sum/
/// Tags: Array, Hash Table
/// </summary>
public class P0001_TwoSum
{
    //O(n^2) time complexity, O(1) space complexity
    public int[] Solucao1(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new[] { i, j };
                }
            }
        }

        return new int[0];
    }
    //O(n log n) time complexity, O(1) space complexity
    public int[] Solucao2(int[] nums, int target)
    {
        Array.Sort(nums);
        int l = 0;
        int r = nums.Length - 1;

        while(l < r)
        {
            int v = nums[l] + nums[r];
            if (v == target)
                return new int[] { l, r };
            r--;
        }

        return Array.Empty<int>();
    }

    //O(n) time complexity, O(n) space complexity
    public int[] Solucao3(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.TryGetValue(complement, out int index))
                return [index, i];
            map[nums[i]] = i;
        }
        return [];
    }
}