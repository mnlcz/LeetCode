using Problems;

namespace Tests;

public class UnitTest1456
{
    private readonly Problem1456 _ins = new();

    [Theory]
    [InlineData("abciiidef", 3, 3)]
    [InlineData("aeiou", 2, 2)]
    [InlineData("leetcode", 3, 2)]
    public void Examples(string s, int k, int expected) => Assert.Equal(expected, _ins.MaxVowels(s, k));
}
