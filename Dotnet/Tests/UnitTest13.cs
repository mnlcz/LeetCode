using Problems;

namespace Tests;

public class UnitTest13
{
    private readonly Problem13 _ins = new();

    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void Examples(string s, int expected) => Assert.Equal(expected, _ins.RomanToInt(s));
}
