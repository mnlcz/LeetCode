namespace Csharp.Challenges.LeetCode75;
public static partial class Solution
{
	public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
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
