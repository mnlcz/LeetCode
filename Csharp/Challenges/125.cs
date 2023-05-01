namespace Challenges;

public static partial class Solution
{
    public static bool IsPalindrome(string s)
    {
        var cleanStr = string.Join("", s.Where(c => char.IsLetterOrDigit(c))).ToLower();
        for (var i = 0; i < cleanStr.Length; i++)
            if (cleanStr[i] != cleanStr[^(i+1)]) return false;
        return true;
    }
}
