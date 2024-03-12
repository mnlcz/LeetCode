namespace Csharp.Challenges;

public static partial class Solution
{
    public static bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;
        var d1 = new Dictionary<char, char>();
        var d2 = new Dictionary<char, char>();
        for (var i = 0; i < s.Length; i++)
        {
            var (c1, c2) = (s[i], t[i]);
            if (d1.ContainsKey(c1) && d1[c1] != c2 || d2.ContainsKey(c2) && d2[c2] != c1) return false;
            d1[c1] = c2;
            d2[c2] = c1;
        }

        return true;
    }
}
