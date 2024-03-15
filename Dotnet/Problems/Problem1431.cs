namespace Problems;

public sealed class Problem1431
{
    // https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/description/
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var max = candies.Max();
        var output = new bool[candies.Length];

        for (var i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= max)
                output[i] = true;
        }

        return output;
    }
}
