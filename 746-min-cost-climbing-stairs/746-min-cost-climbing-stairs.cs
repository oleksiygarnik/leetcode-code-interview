public class Solution {
    public int MinCostClimbingStairs(int[] cost) 
    {
        var dp = new int[cost.Length + 1];
        dp[0] = cost[0];
        dp[1] = cost[1];
        
        for(int i = 2; i <= cost.Length; ++i)
            dp[i] = Math.Min(dp[i - 1], dp[i - 2]) + (i == cost.Length ? 0 : cost[i]);

        return dp[cost.Length];
    }
}