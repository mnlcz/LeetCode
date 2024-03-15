namespace Problems;

public sealed class Problem392
{
    // https://leetcode.com/problems/is-subsequence/description/
    public bool IsSubsequence(string s, string t)
    {
        if (s == t || s.Length == 0) return true;
        if (t.Length == 0) return false;

        var chIdx = 0;

        foreach (var c in t)
        {
            var expected = s[chIdx];
            if (c != expected) continue;
            chIdx++;
            if (chIdx == s.Length) return true;
        }

        return false;
    }
}
