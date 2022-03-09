public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        var result = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                int count = 0;
                if(grid[i][j] == 1)
                    result = Math.Max(result, Dfs(grid, i, j, ref count));
            }
        }
        
        return result;
    }
    
    private int Dfs(int[][] grid, int row, int col, ref int count)
    {
        if(grid[row][col] == 1)
        {
            grid[row][col] = 0;
            count++;
            if(row >= 1) Dfs(grid, row - 1, col, ref count);
            if(col >= 1) Dfs(grid, row, col - 1, ref count);
            if(row < grid.Length - 1) Dfs(grid, row + 1, col, ref count);
            if(col < grid[0].Length - 1) Dfs(grid, row, col + 1, ref count);
        }
        
        return count;
    }
}