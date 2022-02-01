public class Solution {
    public int MaxProfit(int[] prices) {
        var min = prices[0];
        var maxProfit = 0;
        for(int i = 1; i < prices.Length; i++)
        {
            if(min > prices[i])
            {
                min = prices[i];
                continue;
            }
            var profit = prices[i] - min;
            if(profit > maxProfit)
                maxProfit = profit;
        }
        
        return maxProfit;
    }
}
