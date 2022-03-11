public class Solution 
{
    private List<IList<int>> AllPaths = new List<IList<int>>();
    
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) 
    {
        var visited = new bool[graph.Length];
        
        Dfs(graph, new List<int>(){ 0 }, visited, 0);
        
        return AllPaths;
    }
    
    private void Dfs(int[][] graph, List<int> path, bool[] visited, int source)
    {
        if(visited[source])
            return;
        
        if(source == graph.Length - 1)
        {
            AllPaths.Add(path.GetRange(0, path.Count));
            return;
        }
        
        foreach(var neighbour in graph[source])
        {
            if(!visited[neighbour])
            {
                path.Add(neighbour);
                Dfs(graph, path, visited, neighbour);
        
                visited[neighbour] = false;
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}