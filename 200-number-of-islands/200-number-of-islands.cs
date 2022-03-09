public class Solution {
    public int NumIslands(char[][] grid) {
        int result = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[0].Length; j++)
            {
                if(grid[i][j] == '1')
                {
                    result++;
                    Dfs(grid, i, j);
                }
            }
        }
        
        return result;
    }
    
    private void Dfs(char[][] grid, int i, int j)
    {
        if(grid[i][j] == '1')
        {
            grid[i][j] = '0';
            if(i >= 1) Dfs(grid, i - 1, j);
            if(j >= 1) Dfs(grid, i, j - 1);
            if(i < grid.Length - 1) Dfs(grid, i + 1, j);
            if(j < grid[0].Length - 1) Dfs(grid, i, j + 1);
        }
    }
}