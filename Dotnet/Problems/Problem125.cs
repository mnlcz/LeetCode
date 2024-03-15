namespace Problems;

public sealed class Problem125
{
    // https://leetcode.com/problems/valid-palindrome/description/
    public bool IsPalindrome(string s)
    {
        if (s.Length == 1) return true;

        var l = 0;
        var r = s.Length - 1;

        while (l != r && l < r)
        {
            var chL = s[l];
            var chR = s[r];

            if (!char.IsLetterOrDigit(chL))
            {
                l++;
                continue;
            }

            if (!char.IsLetterOrDigit(chR))
            {
                r--;
                continue;
            }

            if (char.IsLetterOrDigit(chL) && char.IsLetterOrDigit(chR))
                if (char.ToLowerInvariant(chL) != char.ToLowerInvariant(chR))
                    return false;

            l++;
            r--;
        }

        return true;
    }
}
