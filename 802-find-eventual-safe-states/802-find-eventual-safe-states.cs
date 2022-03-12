public class Solution 
{
    public List<int> EventualSafeNodes(int[][] graph) 
    {
        var result = new List<int>();
        var color = new int[graph.Length];

        for(int i = 0; i < graph.Length; i++)
            if(Dfs(graph, i, color))
                result.Add(i);

        return result;
    }
    
    // 2 = safe node, 1 = 
    private bool Dfs(int[][] graph, int node, int[] color)
    {
        if(color[node] == 2)
            return true;
        
        if(color[node] == 1)
            return false;
        
        color[node] = 1;
    
        foreach(var neighbour in graph[node])
            if(!Dfs(graph, neighbour, color))
                return false;
        
        color[node] = 2;
        return true;
    }
}