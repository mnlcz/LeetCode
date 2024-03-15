using Problems;

namespace Tests;

public class UnitTest49
{
    private readonly Problem49 _ins = new();

    [Fact]
    public void Example1()
    {
        string[] strs = ["eat", "tea", "tan", "ate", "nat", "bat"];
        string[][] expected = [["bat"], ["nat", "tan"], ["ate", "eat", "tea"]];
        var actual = _ins.GroupAnagrams(strs).Select(g => g.ToArray()).ToArray();

        Assert.True(_compare(expected, actual));
    }

    [Fact]
    public void Example2()
    {
        string[] strs = [""];
        string[][] expected = [[""]];

        var actual = _ins.GroupAnagrams(strs).Select(g => g.ToArray()).ToArray();

        Assert.True(_compare(expected, actual));
    }

    [Fact]
    public void Example3()
    {
        string[] strs = ["a"];
        string[][] expected = [["a"]];

        var actual = _ins.GroupAnagrams(strs).Select(g => g.ToArray()).ToArray();

        Assert.True(_compare(expected, actual));
    }

    private static bool _compare(string[][] expected, string[][] actual)
    {
        if (expected.Length != actual.Length) return false;

        var s1 = expected.OrderBy(x => x.Length).ToArray();
        var s2 = actual.OrderBy(x => x.Length).ToArray();

        for (var i = 0; i < s1.Length; i++)
            if (s1[i].Length != s2[i].Length || !s1[i].All(x => s2[i].Contains(x)))
                return false;

        return true;
    }
}
