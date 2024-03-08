using System.Text.RegularExpressions;

namespace Csharp.Challenges;

public static partial class Solution
{
	public static string GcdOfStrings(string str1, string str2)
	{
		var minStr = str1.Length < str2.Length ? str1 : str2;
		var maxStr = minStr == str1 ? str2 : str1;
		bool validGcd(string source, string candidate) => 
			source == candidate || source.Length == candidate.Length * Regex.Matches(source, candidate).Count;
		var candidate = minStr;
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
