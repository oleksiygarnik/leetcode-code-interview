public class Solution {
    public int MakeConnected(int n, int[][] connections) 
    {
        if(connections.Length < n - 1){
            return -1;
        }
        
        var visited = new bool[n];
        int count = -1;
        
        var matrix = GetMatrix(connections, n);
        
        for(int i = 0; i < n; i++)
        {
            if(!visited[i])
            {
                Dfs(matrix, visited, i);
                count++;
            }
        }
        
        return count;
    }
    
    private void Dfs(Dictionary<int, List<int>> matrix, bool[] visited, int source)
    {
        if(visited[source])
            return;
        
        visited[source] = true;
        
        foreach(var neighbour in matrix[source])
        {
            if(!visited[neighbour])
                Dfs(matrix, visited, neighbour);
        }
    }
    
    private Dictionary<int, List<int>> GetMatrix(int[][] connections, int n)
    {
        var matrix = new Dictionary<int, List<int>>();
        
         for(int i = 0; i < connections.Length; i++)
         {
             if(matrix.TryGetValue(connections[i][0], out var _))
                 matrix[connections[i][0]].Add(connections[i][1]);
             else
                 matrix.Add(connections[i][0], new List<int>(){ connections[i][1] });
            
            if(matrix.TryGetValue(connections[i][1], out var _))
                 matrix[connections[i][1]].Add(connections[i][0]);
             else
                 matrix.Add(connections[i][1], new List<int>(){ connections[i][0] });
         }
        
        for(int i = 0; i < n; i++)
        {
            if(!matrix.ContainsKey(i))
                matrix.Add(i, new List<int>());
        }
        
        return matrix;
    }
}