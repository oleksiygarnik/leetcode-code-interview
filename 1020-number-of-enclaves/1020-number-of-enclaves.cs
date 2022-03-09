public class Solution {
    public int NumEnclaves(int[][] grid) {
        int result = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(!IsBoundary(grid, i, j) & grid[i][j] == 1)
                {
                    int count = 0;
                    if(Dfs(grid, i, j, ref count))
                        result += count;
                }
            }
        }
        
        return result;
    }
    
    private bool IsBoundary(int[][] grid, int row, int col) => 
        row == 0 || col == 0 || row == grid.Length - 1 || col == grid[row].Length - 1;
    
    private bool Dfs(int[][] grid, int row, int col, ref int count)
    {
        if(grid[row][col] == 0)
            return true;
        
        if(IsBoundary(grid, row, col))
            return false;
        
        count++;
        grid[row][col] = 0;
        
        return Dfs(grid, row - 1, col, ref count) &
            Dfs(grid, row + 1, col, ref count) &
            Dfs(grid, row, col - 1, ref count) &
            Dfs(grid, row, col + 1, ref count);
    }
}