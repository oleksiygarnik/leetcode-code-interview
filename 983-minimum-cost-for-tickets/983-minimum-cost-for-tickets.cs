public class Solution {
    public int MincostTickets(int[] days, int[] costs) 
    {
        var unique = new HashSet<int>(days);
        var dp = new int[days[days.Length - 1] + 1];

        for(int i = 1; i < dp.Length; i++)
        {
            if(unique.Contains(i))
            {
                int day = dp[i - 1];
                int week = i - 7 > 0 ? dp[i - 7] : 0;
                int month = i - 30 > 0 ? dp[i - 30] : 0;
            
                dp[i] = Math.Min(Math.Min(month + costs[2], week + costs[1]), day + costs[0]);
            }
            else
               dp[i] = dp[i - 1];
        }
       
        return dp[days[days.Length - 1]];
    }
}