public class Solution 
{   
    public int MaxDistance(int[][] grid) 
    {
        var lands = new List<Tuple<int, int>>();
        
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] == 1)
                    lands.Add(Tuple.Create(i,j));
            }
        }
        
        if(lands.Count() == 0)
            return -1;
        
        var maxDistance = -1;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] == 0)
                    maxDistance = Math.Max(maxDistance, CalculateMaxDistance(i, j, lands));
            }
        }
        
        return maxDistance;
    }
    
    private int CalculateMaxDistance(int row, int column, List<Tuple<int,int>> lands)
    {
        int maxDistance = int.MaxValue;
        foreach(var keyValue in lands)
        {
            var distance = Math.Abs(row - keyValue.Item1) + Math.Abs(column - keyValue.Item2);
            maxDistance = Math.Min(maxDistance, distance);
        }
        
        return maxDistance;
    }
}

// public class Solution 
// {
//     private static int[] directionsRow = new int[]{ 0, -1, 0, 1 };
//     private static int[] directionsColumn = new int[] { -1, 0, 1, 0 };
    
//     public int MaxDistance(int[][] grid) 
//     {
//         var queue = new Queue<(int row, int column)>();
//         var maxDistance = -1;
        
//         for(int i = 0; i < grid.Length; i++)
//         {
//             for(int j = 0; j < grid[i].Length; j++)
//             {
//                 if(grid[i][j] == 0)
//                 {
//                     queue.Clear();
//                     queue.Enqueue((i, j));

//                     maxDistance = Math.Max(maxDistance, Bfs(queue, grid, i, j, new bool[grid.Length, grid[0].Length]));
//                 }
//             }
//         }
        
//         return maxDistance;
//     }
    
//     private int Bfs(Queue<(int row, int column)> queue, int[][] grid, int startRow, int startColumn, bool[,] visited)
//     {   
//         visited[startRow,startColumn] = true;
        
//         while(queue.Count() > 0)
//         {
//             (int row, int column) = queue.Dequeue();
            
//             for(int i = 0; i < 4; i++)
//             {
//                 var newRow = row + directionsRow[i];
//                 var newColumn = column + directionsColumn[i];
                
//                 if(IsValid(grid, newRow, newColumn, visited))
//                 {
//                     if(grid[newRow][newColumn] == 0)
//                     {
//                         visited[newRow,newColumn] = true;
//                         queue.Enqueue((newRow, newColumn));
//                     }
//                     else
//                         return Math.Abs(startRow - newRow) + Math.Abs(startColumn - newColumn);
//                 }
//             }
//         }
        
//         return -1;
//     }
    
//     private bool IsValid(int[][] grid, int row, int column, bool[,] visited)
//     {
//         if(row < 0 || column < 0 || row >= grid.Length || column >= grid[row].Length || visited[row, column])
//             return false;
        
//         return true;
//     }
// }