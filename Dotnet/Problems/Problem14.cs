namespace Problems;

public sealed class Problem14
{
    // https://leetcode.com/problems/longest-common-prefix/description/
    public string LongestCommonPrefix(string[] words)
    {
        var commonPrefix = "";

        for (var i = 0; i < words[0].Length; i++)
        {
            foreach (var s in words)
                if (i == s.Length || s[i] != words[0][i])
                    return commonPrefix;

            commonPrefix += words[0][i];
        }

        return commonPrefix;
    }
}
