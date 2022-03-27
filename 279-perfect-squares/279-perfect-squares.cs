public class Solution 
{
    public int NumSquares(int n) 
    {
        var dp = new int[n + 1];
        
        for(int i = 1; i <= n; i++)
        {
            dp[i] = int.MaxValue;
            for(int j = 1; j * j <= i; j++)
                dp[i] = Math.Min(dp[i], dp[i - j*j] + 1);
            
            Console.WriteLine();
        }
        
        return dp[n];
        
        
        
        
        
//         var square = new List<int>();
//         for(int i = 1; i * i <= n; i++)
//             square.Add(i * i);
        
//         var queue = new Queue<int>();
//         queue.Enqueue(0);
        
//         var distance = 1;
//         var visited = new HashSet<int>();
        
//         if(visited.Contains(n))
//             return 1;
        
//         while(queue.Count() > 0)
//         {
//             var size = queue.Count();
//             while(size-- > 0)
//             {
//                 var current = queue.Dequeue();
            
//                  if(current == n)
//                     return distance;
                
//                 foreach(var num in square)
//                 {
//                     var newNum = current + num;
                    
//                      if(newNum == n)
//                         return distance;
                    
//                     if(newNum < n && !visited.Contains(newNum))
//                     {
//                         queue.Enqueue(newNum);
//                         visited.Add(newNum);
//                     }
//                 }
//             }
            
//             distance++;
//         }
        
//         return distance;
    }
}