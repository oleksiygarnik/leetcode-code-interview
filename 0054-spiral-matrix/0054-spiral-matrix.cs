public class Solution {
    
    public enum Direction
    {
        Up, 
        Down,
        Left,
        Right
    }
    
    public IList<int> SpiralOrder(int[][] matrix) 
    {
        var result = new List<int>();
        var iterationCount = matrix[0].Length / 2 + 1;
        int startRow = 0;
        int startColumn = 0;
        int finishRow = matrix.Length - 1;
        int finishColumn = matrix[0].Length - 1;
        
        while(startRow <= finishRow && startColumn <= finishColumn)
        {
            TraversalColumn(startRow, startColumn, finishColumn, result, matrix, Direction.Right);
            startRow++;
            TraversalRow(finishColumn, startRow, finishRow, result, matrix, Direction.Down);
            finishColumn--;
            if(finishRow >= startRow)
            {
            TraversalColumn(finishRow, finishColumn, startColumn, result, matrix, Direction.Left);
            finishRow--;
            }
            
            if(finishColumn >= startColumn)
            {
            TraversalRow(startColumn, finishRow, startRow, result, matrix, Direction.Up);
            startColumn++;
            }
        }
        
        return result;
    }
    
    private void TraversalColumn(int row, int startColumn, int finishColumn, List<int> result, int[][] matrix, Direction direction)
    {
        if(direction == Direction.Right)
        {
        for(int i = startColumn; i <= finishColumn; i++)
            result.Add(matrix[row][i]);
        }
        else
        {
            for(int i = startColumn; i >= finishColumn; i--)
                result.Add(matrix[row][i]);
        }
    }
    
    private void TraversalRow(int column, int startRow, int finishRow, List<int> result, int[][] matrix, Direction direction)
    {
        if(direction == Direction.Down)
        {
        for(int i = startRow; i <= finishRow; i++)
            result.Add(matrix[i][column]);
        }
        else
        {
            for(int i = startRow; i >= finishRow; i--)
                result.Add(matrix[i][column]);
        }
    }
}