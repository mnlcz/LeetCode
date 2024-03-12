namespace Csharp.Challenges;

public static partial class Solution
{
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, IList<string>>();

        foreach (var str in strs)
        {
            var sorted = SortString(str);

            if (groups.ContainsKey(sorted))
                groups[sorted].Add(str);
            else
                groups[sorted] = new List<string>() { str };
        }

        return groups.Values.ToList();
    }

    private static string SortString(string str)
    {
        var chars = str.ToCharArray();

        Array.Sort(chars);

        return new string(chars);
    }
}
