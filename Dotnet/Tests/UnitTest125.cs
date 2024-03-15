using Problems;

namespace Tests;

public class UnitTest125
{
    private readonly Problem125 _ins = new();

    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData("race a car", false)]
    [InlineData(" ", true)]
    public void Examples(string s, bool expected) => Assert.Equal(expected, _ins.IsPalindrome(s));
}
