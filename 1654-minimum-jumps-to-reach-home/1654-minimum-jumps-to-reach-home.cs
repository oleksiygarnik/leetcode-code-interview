public class Solution {
    public int MinimumJumps(int[] forbidden, int a, int b, int x) 
    {
        var forbiddenList = new List<int>();
        for(int i = 0; i < forbidden.Length; i++)
            forbiddenList.Add(forbidden[i]);
        
        var queue = new Queue<(int, bool)>();
        queue.Enqueue((0, false));
        var result = 0;
        var visited = new List<(int, bool)>();
        visited.Add((0, true));
        visited.Add((0, false));
        
        while(queue.Count() > 0)
        {
            var size = queue.Count();
            while(size-- > 0)
            {
                var current = queue.Dequeue();
                
                var value = current.Item1;
                
                if(value == x)
                    return result;
                
                var state = current.Item2;
                
                var forward = value + a;
                var backward = value - b;
                
                if(forward < 6000 && !forbiddenList.Contains(forward) && !visited.Contains((forward, false)))
                {
                    visited.Add((forward, false));
                    queue.Enqueue((forward, false));
                }
                
                if(backward > 0 && !state && !forbiddenList.Contains(backward) && !visited.Contains((backward, true)))
                {
                    visited.Add((backward, true));
                    queue.Enqueue((backward, true));
                }
            }
            
            result++;
        }
        
        return -1;
    }
}