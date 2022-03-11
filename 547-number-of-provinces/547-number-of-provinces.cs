public class Solution {
    public int FindCircleNum(int[][] isConnected) 
    {
        var result = 0;
        var visited = new bool[isConnected.Length];
        for(int i = 0; i < isConnected.Length; i++)
        {
            if(!visited[i])
            {
                Dfs(isConnected, visited, i);
                result++;
            }
        }
        
        return result;
    }
    
    public void Dfs(int[][] isConnected, bool[] visited, int source)
    {
        if(visited[source])
            return;
        
        visited[source] = true;
        
        for(int i = 0; i < isConnected[source].Length; i++)
        {
            if(i == source)
                continue;
            
            if(isConnected[source][i] == 1)
            {
                Dfs(isConnected, visited, i);
            }
        }
    }
}



































//     var isVisited = new bool[isConnected.Length];
//         int count = 0;
//         for(int i = 0; i < isConnected.Length; i++)
//         {
//             if(!isVisited[i])
//             {
//                 Dfs(isConnected, isVisited, i);
//                 count++;
//             }
//         }
        
        
//         return count;



// for(int j = 0; j < isConnected.Length; j++)
//         {
//             if(source == j)
//                 continue;
            
//             if(!isVisited[j] && isConnected[source][j] == 1)
//             {
//                 isVisited[j] = true;
//                 Dfs(isConnected, isVisited, j);
//             }
//         }