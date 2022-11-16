namespace _1;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new();
        for (int i = 0; i < nums.Length; i++)
        {
            int diferencia = target - nums[i];
            if (dict.ContainsKey(diferencia))
                return new[] { dict[diferencia], i };

            if (!dict.ContainsKey(nums[i]))
                dict.Add(nums[i], i);
        }

        return new[] { -99, -99 };
    }
}
