using Problems;

namespace Tests;

public class UnitTest9
{
    private readonly Problem9 _ins = new();

    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    public void Examples(int x, bool expected) => Assert.Equal(expected, _ins.IsPalindrome(x));
}
