using Problems;

namespace Tests;

public class UnitTest121
{
    private readonly Problem121 _ins = new();

    [Theory]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
    public void Examples(int[] prices, int expected) => Assert.Equal(expected, _ins.MaxProfit(prices));
}
