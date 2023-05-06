namespace Csharp.Challenges;

public static partial class Solution
{
    public static int MaxVowels(string s, int k)
    {
        bool IsVowel(char c) => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        var (counter, l, max) = (0, 0, 0);
        for (var r = 0; r < s.Length; r++)
        {
            if (IsVowel(s[r])) counter++;
            if (r - l + 1 > k)
            {
                if (IsVowel(s[l])) counter--;
                l++;
            }

            max = counter > max ? counter : max;
        }

        return max;
    }
}
