using Problems;

namespace Tests;

public class UnitTest205
{
    private readonly Problem205 _ins = new();

    [Theory]
    [InlineData("egg", "add", true)]
    [InlineData("foo", "bar", false)]
    [InlineData("paper", "title", true)]
    public void Examples(string s, string t, bool expected) => Assert.Equal(expected, _ins.IsIsomorphic(s, t));
}
