public class Solution 
{
    public List<int> EventualSafeNodes(int[][] graph) 
    {
        List<int> res = new List<int>();
        int[] color = new int[graph.Length];

        for(int i =+ 0; i < graph.Length; i++)
        {
            if(Dfs(graph, i, color))
                res.Add(i);
        }

        return res;
    }
    
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


// private int dfs(int[][] adj, int src, int[] vis){
//     if(vis[src] != 0) return vis[src];//0 represents unvisited node

//     vis[src] = -1;//-1 represents current search

//     foreach(int neighbor in adj[src])
//         if(dfs(adj, neighbor, vis) == -1) 
//             return -1;//unsafe node return immediately 

//     return vis[src] = 1;//1 represents safe node
// }