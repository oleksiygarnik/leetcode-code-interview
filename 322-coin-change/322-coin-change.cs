public class Solution 
{
    public int CoinChange(int[] coins, int amount) 
    {
        var dp = new int[amount + 1];
        
        for(int i = 1; i <= amount; i++)
        {
            dp[i] = int.MaxValue;
            for(int j = 0; j < coins.Length; j++)
            {
                if(coins[j] <= i &&  dp[i - coins[j]] != int.MaxValue)
                    dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
            }
        }
        
        return dp[amount] == int.MaxValue ? -1 : dp[amount];
    }
    
    
    //         var visited = new HashSet<int>();
//         var queue = new Queue<int>();
//         queue.Enqueue(0);
//         var distance = 0;
        
//         while(queue.Count() > 0)
//         {
//             var size = queue.Count();
//             while(size-- > 0)
//             {
//                 var current = queue.Dequeue();
                
//                 if(current == amount)
//                     return distance;
                
//                 foreach(var coin in coins)
//                 {
//                     var newAmount = current + coin;
                    
//                     if(newAmount <= amount && !visited.Contains(newAmount))
//                     {
//                         visited.Add(newAmount);
//                         queue.Enqueue(newAmount);
//                     }
//                 }
//             }
            
//             distance++;
//         }
        
//         return -1;
}