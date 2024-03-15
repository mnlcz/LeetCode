using Problems;

namespace Tests;

public class UnitTest392
{
    private readonly Problem392 _ins = new();

    [Theory]
    [InlineData("abc", "ahbgdc", true)]
    [InlineData("axc", "ahbgdc", false)]
    public void Examples(string s, string t, bool expected) => Assert.Equal(expected, _ins.IsSubsequence(s, t));
}
