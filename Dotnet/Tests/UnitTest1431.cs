using Problems;

namespace Tests;

public class UnitTest1431
{
    private readonly Problem1431 _ins = new();

    [Theory]
    [InlineData(new[] { 2, 3, 5, 1, 3 }, 3, new[] { true, true, true, false, true })]
    [InlineData(new[] { 4, 2, 1, 1, 2 }, 1, new[] { true, false, false, false, false })]
    [InlineData(new[] { 12, 1, 12 }, 10, new[] { true, false, true })]
    public void Examples(int[] candies, int extraCandies, bool[] expected) =>
        Assert.True(expected.SequenceEqual(_ins.KidsWithCandies(candies, extraCandies)));
}
