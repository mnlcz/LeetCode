using Problems;

namespace Tests;

public class UnitTest605
{
    private readonly Problem605 _ins = new();

    [Theory]
    [InlineData(new[] { 1, 0, 0, 0, 1 }, 1, true)]
    [InlineData(new[] { 1, 0, 0, 0, 1 }, 2, false)]
    public void Examples(int[] flowerbed, int n, bool expected) => Assert.Equal(expected, _ins.CanPlaceFlowers(flowerbed, n));
}
