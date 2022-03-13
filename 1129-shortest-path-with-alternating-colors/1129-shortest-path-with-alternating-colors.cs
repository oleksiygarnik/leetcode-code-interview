public class Solution {
    public int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges) {
        
        var storage = new Dictionary<int, List<Tuple<int,int>>>();
        for(int i = 0; i < n; i++)
            storage.Add(i, new List<Tuple<int,int>>());
        
        //0 - red
        for(int i = 0; i < redEdges.Length; i++)
            storage[redEdges[i][0]].Add(Tuple.Create(redEdges[i][1], 0));
        
        //1 - blue
        for(int i = 0; i < blueEdges.Length; i++)
            storage[blueEdges[i][0]].Add(Tuple.Create(blueEdges[i][1], 1));
        
        return Bfs(storage, n);
    }
    
    private int[] Bfs(Dictionary<int, List<Tuple<int, int>>> storage, int n)
    {
        var result = new int[n];
        Array.Fill(result, -1);
        
        var visited = new HashSet<(int, int)>();
        var queue = new Queue<Tuple<int,int>>();
        queue.Enqueue(Tuple.Create(0,0));
        queue.Enqueue(Tuple.Create(0,1));
        
        int distance = 0;
        
        while(queue.Count() > 0)
        {
            var count = queue.Count();
            for(int i = 0; i < count; i++)
            {
                var current = queue.Dequeue();
            
                var node = current.Item1;
                var color = current.Item2;
            
                visited.Add((node, color));
                if(result[node] == -1)
                    result[node] = distance;
            
                foreach(var neighbour in storage[node])
                {
                    if(visited.Contains((neighbour.Item1, neighbour.Item2)))
                        continue;
                    
                    if(color == 0 && neighbour.Item2 == 1)
                    {
                         visited.Add((neighbour.Item1, 1));
                         queue.Enqueue(Tuple.Create(neighbour.Item1, 1));
                    }
                    else if(color == 1 && neighbour.Item2 == 0)
                    {
                         visited.Add((neighbour.Item1, 0));
                         queue.Enqueue(Tuple.Create(neighbour.Item1, 0));
                    }
                }
            }
            
            distance++;
        }
        
        return result;
    }
}