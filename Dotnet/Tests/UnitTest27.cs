using Problems;

namespace Tests;

public class UnitTest27
{
    private readonly Problem27 _ins = new();

    [Theory]
    [InlineData(new[] { 3, 2, 2, 3 }, 3, 2)]
    [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
    public void Examples(int[] nums, int val, int expected) => Assert.Equal(expected, _ins.RemoveElement(nums, val));
}
