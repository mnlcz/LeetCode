using Problems;

namespace Tests;

public class UnitTest1480
{
    private readonly Problem1480 _ins = new();

    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 })]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new[] { 3, 1, 2, 10, 1 }, new[] { 3, 4, 6, 16, 17 })]
    public void Examples(int[] nums, int[] expected) => Assert.True(expected.SequenceEqual(_ins.RunningSum(nums)));
}
