using Problems;

namespace Tests;

public class UnitTest724
{
    private readonly Problem724 _ins = new();

    [Theory]
    [InlineData(new[] { 1, 7, 3, 6, 5, 6 }, 3)]
    [InlineData(new[] { 1, 2, 3 }, -1)]
    [InlineData(new[] { 2, 1, -1 }, 0)]
    public void Examples(int[] nums, int expected) => Assert.Equal(expected, _ins.PivotIndex(nums));
}
