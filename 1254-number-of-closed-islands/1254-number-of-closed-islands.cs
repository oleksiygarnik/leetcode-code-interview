public class Solution {
    public int ClosedIsland(int[][] grid) {
        int count = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] == 0 && Dfs(grid, i, j))
                    count++;
            }
        }
        
        return count;
    }
    
    private bool Dfs(int[][] grid, int row, int col)
    {
        if(row < 0 || col < 0 || row > grid.Length - 1 || col > grid[row].Length - 1)
            return false;
        
        if(grid[row][col] == 1)
            return true;
        
        grid[row][col] = 1;
        
        return Dfs(grid, row - 1, col) &
            Dfs(grid, row, col - 1) &
            Dfs(grid, row + 1, col) &
            Dfs(grid, row, col + 1);
    }
}