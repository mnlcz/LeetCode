namespace Problems;

public sealed class Problem49
{
    // https://leetcode.com/problems/group-anagrams/description/
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, IList<string>>();

        foreach (var str in strs)
        {
            var sorted = string.Join("", str.ToCharArray().Order());

            if (groups.TryGetValue(sorted, out var group))
                group.Add(str);
            else
                groups[sorted] = [str];
        }

        return groups.Values.ToArray();
    }
}
