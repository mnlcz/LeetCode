using Problems;

namespace Tests;

public class UnitTest1071
{
    private readonly Problem1071 _ins = new();

    [Theory]
    [InlineData("ABCABC", "ABC", "ABC")]
    [InlineData("ABABAB", "ABAB", "AB")]
    [InlineData("LEET", "CODE", "")]
    public void Examples(string str1, string str2, string expected) => Assert.Equal(expected, _ins.GcdOfStrings(str1, str2));
}
