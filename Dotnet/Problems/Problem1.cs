namespace Problems;

public sealed class Problem1
{
    // https://leetcode.com/problems/two-sum/description/
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = [];

        for (var i = 0; i < nums.Length; i++)
        {
            var diferencia = target - nums[i];
            if (dict.TryGetValue(diferencia, out var value))
                return [value, i];

            dict.TryAdd(nums[i], i);
        }

        return [];
    }
}
