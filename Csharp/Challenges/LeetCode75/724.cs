namespace Csharp.Challenges.LeetCode75;

public static partial class Solution
{
    public static int PivotIndex(int[] nums)
    {
        var total = nums.Sum();
        var lSum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            var rSum = total - nums[i] - lSum;
            if (lSum == rSum) return i;
            lSum += nums[i];
        }

        return -1;
    }
}
