public class Solution 
{
//     public int TwoCitySchedCost(int[][] costs) 
//     {
//         Array.Sort(costs, (x, y) => (x[0] - x[1]).CompareTo(y[0] - y[1]));
        
//         var result = 0;
//         for(int i = 0; i < costs.Length/2; i++)
//             result += costs[i][0] + costs[i + costs.Length/2][1]; 
        
//         return result;
//     }
    
        public int TwoCitySchedCost(int[][] costs) 
        {
            int N = costs.Length / 2;
            int[][] dp = new int[N + 1][];
            for(int i = 0; i < dp.Length; i++)
                dp[i] = new int[N +1];
            
            for (int i = 1; i <= N; i++) 
                dp[i][0] = dp[i - 1][0] + costs[i - 1][0];

            for (int j = 1; j <= N; j++)
                dp[0][j] = dp[0][j - 1] + costs[j - 1][1];

            for (int i = 1; i <= N; i++) 
                for (int j = 1; j <= N; j++) 
                    dp[i][j] = Math.Min(dp[i - 1][j] + costs[i + j - 1][0], dp[i][j - 1] + costs[i + j - 1][1]);

            return dp[N][N];
        }
}