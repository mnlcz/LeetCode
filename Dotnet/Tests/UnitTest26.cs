using Problems;

namespace Tests;

public class UnitTest26
{
    private readonly Problem26 _ins = new();

    [Theory]
    [InlineData(new[] { 1, 1, 2 }, 2)]
    [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void Examples(int[] nums, int expected) => Assert.Equal(expected, _ins.RemoveDuplicates(nums));
}
