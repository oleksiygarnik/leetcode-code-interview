public class Solution {
    public int[] FindBall(int[][] grid) 
    {
        var length = grid[0].Length;
        var result = new int[length];
        
        for(int i = 0; i < length; i++)
            result[i] = FindIndex(grid, i);
        
        return result;
    }
    
    public int FindIndex(int[][] grid, int ballIndex)
    {
        var columns = grid[0].Length;

        for(int row = 0; row < grid.Length; row++)
        {
            var direction = grid[row][ballIndex];
            
            if((ballIndex == columns - 1 && direction == 1) ||
              (ballIndex == 0 && direction == -1))
                return -1;
            
            if(direction != grid[row][direction + ballIndex])
               return -1;
               
            ballIndex += direction;
        }
        
        return ballIndex;
    }
}