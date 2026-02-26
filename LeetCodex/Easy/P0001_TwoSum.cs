namespace LeetCodex.Easy;

/// <summary>
/// LeetCode #1 - Two Sum (Easy)
/// https://leetcode.com/problems/two-sum/
/// Tags: Array, Hash Table
/// </summary>
public class P0001_TwoSum
{
    public int[] Solve(int[] nums, int target)
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