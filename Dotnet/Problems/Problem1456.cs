namespace Problems;

public sealed class Problem1456
{
    // https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/description/
    public int MaxVowels(string s, int k)
    {
        static bool IsVowel(char c) => c is 'a' or 'e' or 'i' or 'o' or 'u';

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
