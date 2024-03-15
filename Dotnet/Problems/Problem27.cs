namespace Problems;

public sealed class Problem27
{
    // https://leetcode.com/problems/remove-element/description/
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0)
            return 0;

        var left = 0;

        for (var right = 0; right < nums.Length; right++)
        {
            if (nums[right] != val)
            {
                nums[left] = nums[right];
                left++;
            }
        }

        return left;
    }
}
