namespace Csharp.Challenges;

public static partial class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new();
        for (var i = 0; i < nums.Length; i++)
        {
            var diferencia = target - nums[i];
            if (dict.ContainsKey(diferencia))
                return new[] { dict[diferencia], i };

            if (!dict.ContainsKey(nums[i]))
                dict.Add(nums[i], i);
        }

        return new[] { -99, -99 };
    }
}
