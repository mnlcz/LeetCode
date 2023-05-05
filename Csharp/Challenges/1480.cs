namespace Challenges;

public static partial class Solution
{
    public static int[] RunningSum(int[] nums)
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
