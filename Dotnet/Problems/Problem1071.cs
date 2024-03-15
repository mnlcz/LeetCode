using System.Text.RegularExpressions;

namespace Problems;

public sealed class Problem1071
{
    // https://leetcode.com/problems/greatest-common-divisor-of-strings/description/  
    public string GcdOfStrings(string str1, string str2)
    {
        var minStr = str1.Length < str2.Length ? str1 : str2;
        var maxStr = minStr == str1 ? str2 : str1;
        var candidate = minStr;

        static bool validGcd(string source, string candidate)
        {
            return source == candidate || source.Length == candidate.Length * Regex.Matches(source, candidate).Count;
        }

        while (candidate.Length > 0)
        {
            if (validGcd(minStr, candidate))
            {
                if (validGcd(maxStr, candidate))
                    return candidate;
            }
            candidate = candidate[0..(candidate.Length - 1)];
        }

        return "";
    }
}
