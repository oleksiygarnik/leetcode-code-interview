public class Solution {
    public int CoinChange(int[] coins, int amount) 
    {
        var visited = new HashSet<int>();
        var queue = new Queue<int>();
        queue.Enqueue(0);
        var distance = 0;
        
        while(queue.Count() > 0)
        {
            var size = queue.Count();
            while(size-- > 0)
            {
                var current = queue.Dequeue();
                
                if(current == amount)
                    return distance;
                
                foreach(var coin in coins)
                {
                    var newAmount = current + coin;
                    
                    if(newAmount <= amount && !visited.Contains(newAmount))
                    {
                        visited.Add(newAmount);
                        queue.Enqueue(newAmount);
                    }
                }
            }
            
            distance++;
        }
        
        return -1;
    }
}