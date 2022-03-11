public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) 
    {
        var result = new List<IList<int>>();
        
        var path = new List<int>();
        path.Add(0);
        var visited = new bool[graph.Length];
        
        foreach(var neighbour in graph[0])
        {
            if(!visited[neighbour])
            {
                path.Add(neighbour);
                Dfs(result, graph, path, visited, neighbour);
                
                visited[neighbour] = false;
                path.RemoveAt(path.Count - 1);
                
            }
        }
        
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






































// public class Solution {
    
//     public static IList<IList<int>> result;
//     public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
//         result = new List<IList<int>>();
        
//         var maxElem = graph.SelectMany(x => x).Max();
//         var visited = new bool[maxElem + 1];
//         var stack = new Stack<int>();
//         stack.Push(0);
        
//         var path = new List<int>();
//         while(stack.Count() > 0)
//         {
//             var currentVertex = stack.Pop();
            
//             if(visited[currentVertex] == true)
//                 continue;
            
//             visited[currentVertex] = true;
//             path.Add(currentVertex);
            
//             if(currentVertex == maxElem)
//             {
//                 var pathResult = path.GetRange(0, path.Count);
//                 result.Add(pathResult);
//                 break;
//             }
            
//             foreach(var nextVertex in graph[currentVertex])
//             {
//                 if(visited[nextVertex] == false)
//                 {
//                     stack.Push(nextVertex);
//                     SearchUtil(visited, path, stack, graph, maxElem);
                    
//                     path.RemoveAt(path.Count - 1);
//                     visited[nextVertex] = false;
//                 }
//             }
//         }
        
//         return result;
//     }
    
//     private void SearchUtil(bool[] visited, List<int> path, Stack<int> stack, int[][] graph, int maxElem)
//     {
//             var currentVertex = stack.Pop();
            
//             if(visited[currentVertex] == true)
//                 return;
            
//             visited[currentVertex] = true;
//             path.Add(currentVertex);
            
//             if(currentVertex == maxElem)
//             {
//                 var pathResult = path.GetRange(0, path.Count);
//                 result.Add(pathResult);
//                 return;
//             }
            
//             foreach(var nextVertex in graph[currentVertex])
//             {
//                 if(visited[nextVertex] == false)
//                 {
//                     stack.Push(nextVertex);
//                     SearchUtil(visited, path, stack, graph, maxElem);
                    
//                     //Reset
//                     path.RemoveAt(path.Count - 1);
//                     visited[nextVertex] = false;
//                 }
//             }
//     }
// }