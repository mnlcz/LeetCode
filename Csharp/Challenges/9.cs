namespace Challenges;

public static partial class Solution
{
    public static bool IsPalindrome(int x)
    {
        var s1 = x.ToString();
        var s2 = s1.ToCharArray();
        Array.Reverse(s2);
        return s1 == new string(s2);
    }
}
