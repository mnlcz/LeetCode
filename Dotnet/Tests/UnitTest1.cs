using Problems;

namespace Tests;

public class UnitTest1
{
    private readonly Problem1 _ins = new();

    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    public void Examples(int[] nums, int target, int[] expected)
    {
        var res = _ins.TwoSum(nums, target);
        Assert.True(expected.SequenceEqual(res));
    }
}
