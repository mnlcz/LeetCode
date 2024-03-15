namespace Problems;

public sealed class Problem1480
{
    // https://leetcode.com/problems/running-sum-of-1d-array/description/
    public int[] RunningSum(int[] nums)
    {
        var newArr = new int[nums.Length];
        var prev = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            newArr[i] = nums[i] + prev;
            prev += nums[i];
        }

        return newArr;
    }
}
