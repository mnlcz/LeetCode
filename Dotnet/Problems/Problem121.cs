namespace Problems;

public sealed class Problem121
{
    // https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
    public int MaxProfit(int[] prices)
    {
        var (possible, output) = Lazy(prices);

        if (possible)
            return output;

        var l = 0;
        var r = 1;
        var max = 0;

        while (true)
        {
            if (r == prices.Length)
                break;

            if (prices[l] < prices[r])
            {
                var profit = prices[r] - prices[l];
                if (profit > max)
                    max = profit;
                r++;
            }
            else if (prices[l] >= prices[r])
            {
                l = r;
                r++;
            }
        }
        return max;
    }

    private static (bool possible, int output) Lazy(int[] prices)
    {
        return prices.Length switch
        {
            1 => (true, 0),
            2 => prices[1] > prices[0] ? (true, prices[1] - prices[0]) : (false, -1),
            _ => (false, -1)
        };
    }
}
