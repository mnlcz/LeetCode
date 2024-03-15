using Problems;

namespace Tests;

public class UnitTest14
{
    private readonly Problem14 _ins = new();

    [Theory]
    [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new[] { "dog", "racecar", "car" }, "")]
    public void Examples(string[] strs, string expected) => Assert.Equal(expected, _ins.LongestCommonPrefix(strs));
}
