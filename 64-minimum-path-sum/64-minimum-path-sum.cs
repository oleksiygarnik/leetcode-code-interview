public class Solution 
{
    public int MinPathSum(int[][] grid) 
    {
        int m = grid.Length, n = grid[0].Length;
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(i == 0 && j > 0)
                    grid[i][j] += grid[i][j - 1];
                else if(j == 0 && i > 0)
                    grid[i][j] += grid[i - 1][j];
                else if(i > 0 && j > 0)
                    grid[i][j] += Math.Min(grid[i - 1][j], grid[i][j - 1]);
            }
        }
        
        return grid[m - 1][n - 1];
    }
    
//     private static int[] rowDirections = new int[]{ 0, -1, 0, 1};
//     private static int[] columnDirections = new int[]{ -1, 0, 1, 0};
    
//     public int MinPathSum(int[][] grid) 
//     {
//         var queue = new Queue<Tuple<int, int>>();
//         queue.Enqueue(Tuple.Create(0, 0));
        
//         var visited = new bool[grid.Length, grid[0].Length];
//         visited[0,0] = true;
        
//         while(queue.Count > 0)
//         {
//             var current = queue.Dequeue();
//             var row = current.Item1;
//             var column = current.Item2;
            
//             if(row == grid.Length - 1 && column == grid[row].Length - 1)
//                 return grid[row][column];
            
//             for(int i = 0; i < 4; i++)
//             {
//                 var newRow = row + rowDirections[i];
//                 var newColumn = column + columnDirections[i];
                
//                 if(IsValid(grid, newRow, newColumn) && !visited[newRow,newColumn])
//                 {
//                     visited[newRow,newColumn] = true;
//                     queue.Enqueue(Tuple.Create(newRow, newColumn));
                    
//                     if(newRow == 0 || newColumn == 0)
//                         grid[newRow][newColumn] += grid[row][column];
//                     else if(newRow > 0 && newRow < grid.Length && newColumn < grid[newRow].Length && newColumn > 0)
//                         grid[newRow][newColumn] += Math.Min(grid[newRow - 1][newColumn], grid[newRow][newColumn - 1]);
//                     // Console.WriteLine(newRow + " " + newColumn + ": " + grid[newRow][newColumn]);
//                 } 
//             }
//         }
        
//         return -1;
//     }
    
//     private bool IsValid(int[][] grid, int row, int column)
//     {
//         if(row < 0 || column < 0 || row > grid.Length - 1 || column > grid[row].Length - 1)
//             return false;
        
//         return true;
//     }
}