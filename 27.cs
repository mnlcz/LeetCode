namespace _27;

public class Solution
{
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
