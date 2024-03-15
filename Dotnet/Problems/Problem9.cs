namespace Problems;

public sealed class Problem9
{
    // https://leetcode.com/problems/palindrome-number/description/
    public bool IsPalindrome(int x)
    {
        var s = x.ToString().ToCharArray();
        var l = 0;
        var r = s.Length - 1;

        while (r != l && r > l)
        {
            if (s[l] != s[r]) return false;
            l++;
            r--;
        }

        return true;
    }
}
