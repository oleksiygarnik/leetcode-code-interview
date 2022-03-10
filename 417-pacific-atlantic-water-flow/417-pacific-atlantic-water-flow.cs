public class Solution {
    public IList<IList<int>> PacificAtlantic(int[][] heights) {
        var result = new List<IList<int>>();
        
        var height = heights.Length;
        var width = heights[0].Length;
        
        var pacificOcean = new bool[height, width];
        var atlanticOcean = new bool[height, width];
        
        for(int i = 0; i < height; i++)
        {
            Dfs(heights, i, 0, int.MinValue, pacificOcean);
            Dfs(heights, i, width - 1, int.MinValue, atlanticOcean);
        }
        
        for(int i = 0; i < width; i++)
        {
            Dfs(heights, 0, i, int.MinValue, pacificOcean);
            Dfs(heights, height - 1, i, int.MinValue, atlanticOcean);
        }
        
        for(int i = 0; i < heights.Length; i++)
        {
            for(int j = 0; j < heights[i].Length; j++)
            {
               if(atlanticOcean[i,j] & pacificOcean[i,j])
               {
                   var point = new List<int>();
                   point.Add(i);
                   point.Add(j);
                   result.Add(point);
               }
            }
        }
        
        return result;
    }
    
    private void Dfs(int[][] heights, int row, int col, int previous, bool[,] ocean)
    {
        if(row < 0 || col < 0 || row >= heights.Length || col >= heights[row].Length || ocean[row, col] || previous > heights[row][col])
            return;
        
        ocean[row,col] = true;
        
        Dfs(heights, row - 1, col, heights[row][col], ocean);
        Dfs(heights, row + 1, col, heights[row][col], ocean);
        Dfs(heights, row, col - 1, heights[row][col], ocean);
        Dfs(heights, row, col + 1, heights[row][col], ocean);
    }
}