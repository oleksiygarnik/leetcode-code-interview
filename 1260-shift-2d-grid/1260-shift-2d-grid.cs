public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) 
    {
       int rowCount = grid.Length;
        int colCount = grid[0].Length;
        
        var answer = new int[rowCount][];
        for(int i = 0; i < rowCount; i++) answer[i] = new int[colCount];
        
        for(int row = 0; row < rowCount; row++){
            for(int col = 0; col < colCount; col++){
                int newCol = (col + k) % colCount;
                int newRow = ( row + ((col + k) / colCount)) % rowCount;
                answer[newRow][newCol] = grid[row][col];
            }
        }
        return answer;
    }
}