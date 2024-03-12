namespace Csharp.Challenges;

public static partial class Solution
{
    public static bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        if (n == 0) return true;
        if (flowerbed.Length == 1)
            return flowerbed[0] == 0 && n == 1;
        var valids = 0;

        for (var i = 0; i < flowerbed.Length; i++)
        {
            if (i == 0 && flowerbed[i] == 0)
            {
                if (flowerbed[i + 1] == 0)
                {
                    valids++;
                    flowerbed[i] = 1;
                }
            }
            else if (i == flowerbed.Length - 1 && flowerbed[i] == 0)
            {
                if (flowerbed[i - 1] == 0)
                {
                    valids++;
                    flowerbed[i] = 1;
                }
            }
            else if (flowerbed[i] == 0)
            {
                if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                {
                    valids++;
                    flowerbed[i] = 1;
                }
            }
        }

        return n <= valids;
    }
}
