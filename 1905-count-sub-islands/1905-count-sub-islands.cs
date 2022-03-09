public class Solution {    
    public int CountSubIslands(int[][] grid1, int[][] grid2) {
        var result = 0;
        for(int i = 0; i < grid2.Length; i++)
        {
            for(int j = 0; j < grid2[i].Length; j++)
            {
                if(grid2[i][j] == 1)
                {
                    bool isCover = true;
                    Dfs(grid1, grid2, i, j, ref isCover);
                    if(isCover)
                        result++;
                }
            }
        }
        
        return result;
    }
    
    private void Dfs(int[][] grid1, int[][] grid2, int row, int col, ref bool isCover)
    {
        if(grid2[row][col] == 1)
        {
             if(grid1[row][col] == 0)
                isCover = false;
        
            grid2[row][col] = 0;
            
            if(row >= 1) Dfs(grid1, grid2, row - 1, col, ref isCover);
            if(col >= 1) Dfs(grid1, grid2, row, col - 1, ref isCover);
            if(row < grid2.Length - 1) Dfs(grid1, grid2, row + 1, col, ref isCover);
            if(col < grid2[row].Length - 1) Dfs(grid1, grid2, row, col + 1, ref isCover);
        }
    }
}