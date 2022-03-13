public class Solution {
    public int MinReorder(int n, int[][] connections) 
    {
        var storage = new Dictionary<int, List<int>>();
        
        for(int i = 0; i < n; i++)
            storage.Add(i, new List<int>());
        
        var oppositeRoads = new Dictionary<int, List<int>>();
        
        for(int i = 0; i < connections.Length; i++)
        {
            storage[connections[i][0]].Add(connections[i][1]);
            storage[connections[i][1]].Add(connections[i][0]);
            
            if(oppositeRoads.ContainsKey(connections[i][1]))
                oppositeRoads[connections[i][1]].Add(connections[i][0]);
            else
                oppositeRoads.Add(connections[i][1], new List<int> { connections[i][0] });
        }
        
        var stack = new Stack<int>();
        stack.Push(0);
        var visited = new bool[n];
        var edgeCount = 0;
        
        while(stack.Count() > 0)
        {
            var current = stack.Pop();
            
            visited[current] = true;
            
            foreach(var neighbour in storage[current])
            {
                if(!visited[neighbour])
                {
                    stack.Push(neighbour);
                    
                    visited[neighbour] = true;
                    
                    if(oppositeRoads.TryGetValue(neighbour, out var result))
                    {
                        if(result.Contains(current))
                            edgeCount++;
                    }
                }
            }
        }
        
        return edgeCount;
    }
    
    private bool IsExist(int[][] connections, int from, int to)
    {
        for(int i = 0; i < connections.Length; i++)
        {
            if(connections[i][0] == from && connections[i][1] == to)
                return true;
        }
        
        return false;
    }
}




































//    var dict = new Dictionary<int, List<int>>();
//         for(int i = 0; i < n; i++){
//             dict.Add(i, new List<int>());
//         }
//         var edges = new HashSet<string>();
        
//         for(int i = 0; i < connections.Length; i++)
//         {
//             edges.Add($"{connections[i][0]},{connections[i][1]}");
//             dict[connections[i][0]].Add(connections[i][1]);
//             dict[connections[i][1]].Add(connections[i][0]);
//         }
//         int edgeCount = 0;
//         var visited = new bool[n];
//         var stack = new Stack<int>();
//         stack.Push(0);
        
//         while(stack.Count > 0)
//         {
//             var current = stack.Pop();
            
//             visited[current] = true;
            
//             foreach(var next in dict[current])
//             {
//                 if(visited[next] == true)
//                     continue;
                
//                 stack.Push(next);

//                 if(!edges.Contains($"{next},{current}"))
//                     edgeCount++;
//             }
//         }
        
//         return edgeCount;