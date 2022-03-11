public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) 
    {
        var result = new List<IList<int>>();
        var visited = new bool[graph.Length];
        
        Dfs(result, graph, new List<int>(){ 0 }, visited, 0);
        
        return result;
    }
    
    private void Dfs(List<IList<int>> result, int[][] graph, List<int> path, bool[] visited, int source)
    {
        if(visited[source])
            return;
        
        if(source == graph.Length - 1)
        {
            result.Add(path.GetRange(0, path.Count));
            return;
        }
        
        foreach(var neighbour in graph[source])
        {
            if(!visited[neighbour])
            {
                path.Add(neighbour);
                Dfs(result, graph, path, visited, neighbour);
        
                visited[neighbour] = false;
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}