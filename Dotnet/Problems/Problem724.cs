namespace Problems;

public sealed class Problem724
{
    // https://leetcode.com/problems/find-pivot-index/description/
    public int PivotIndex(int[] nums)
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
