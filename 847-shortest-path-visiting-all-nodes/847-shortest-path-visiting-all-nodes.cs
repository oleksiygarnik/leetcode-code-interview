public class Solution {
    public int ShortestPathLength(int[][] graph) {
        var endingMask = (1 << graph.Length) - 1;
        var cache = new int[graph.Length + 1, endingMask + 1];
        
        var height = cache.GetUpperBound(0) + 1;
        var width = cache.Length / height;
        
        var result = int.MaxValue;
        for(int i = 0; i < graph.Length; i++)
            result = Math.Min(result, Dp(i, endingMask, graph, cache));
        
        return result;
    }
    
    private int Dp(int node, int mask, int[][] graph, int[,] cache)
    {
        if(cache[node,mask] != 0)
            return cache[node,mask];
        
        if((mask & (mask - 1)) == 0)
            return 0;
        
        cache[node,mask] = int.MaxValue - 1;
        
        foreach(var neighbour in graph[node])
        {
            if((mask & (1 << neighbour)) != 0){
                int alreadyVisited = Dp(neighbour, mask, graph, cache);
                int notVisited = Dp(neighbour, mask ^ (1 << node), graph, cache);
                int better = Math.Min(alreadyVisited, notVisited);
                cache[node,mask] = Math.Min(cache[node,mask], 1 + better);
            }
        }
        
        return cache[node,mask];
    }
}