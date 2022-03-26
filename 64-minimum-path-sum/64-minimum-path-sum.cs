public class Solution 
{
    public int MinPathSum(int[][] grid) 
    {
        int m = grid.Length;
        int n = grid[0].Length;
        
        var dp = new int[m, n];
        for(int i = 0; i < m ; i++)
        {
            if(i == 0)
                dp[i, 0] = grid[0][0];
            else
                dp[i, 0] = dp[i - 1, 0] + grid[i][0];
        }
        
         for(int i = 1; i < n ; i++)
         {
             if(i == 0)
                dp[0,i] = grid[0][0];
            else
                dp[0, i] = dp[0, i - 1] + grid[0][i];
         }
        
        for(int i = 1; i < m; i++)
        {
            for(int j = 1; j < n; j++)
            {
                 dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - 1]) + grid[i][j];
                //dp[i, j] = Math.Min(dp[i - 1, j], dp[i, j - 1]) + grid[i - 1][j - 1];
                 Console.WriteLine(i + " " + j + ": " + dp[i, j]);
            }
        }
        
        return dp[m - 1, n - 1];
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