public class Solution 
{
    public int ShortestPathBinaryMatrix(int[][] grid) 
    {
        var directionsRow = new int[]{ -1, -1, -1, 0, 0, 0, 1, 1, 1 };
        var directionsColumn = new int[]{ -1, 0, 1, -1, 0, 1, -1, 0, 1 };
        
        if(grid[0][0] != 0 || grid[grid.Length - 1][grid.Length - 1] != 0)
            return -1;
        
        var queue = new Queue<Tuple<int, int>>();
        queue.Enqueue(Tuple.Create(0, 0));
        grid[0][0] = 1;
        
        while(queue.Count() > 0)
        {
            var current = queue.Dequeue();
            
            var row = current.Item1;
            var column = current.Item2;
            var distance = grid[row][column];
            
            if(row == grid.Length - 1 && column == grid[row].Length - 1)
                return distance;
            
            for(int i = 0; i < 9; i++)
            {
                var newRow = row + directionsRow[i];
                var newColumn = column + directionsColumn[i];
                
                if(IsValid(grid, newRow, newColumn))
                {
                    queue.Enqueue(Tuple.Create(newRow, newColumn));
                    
                    grid[newRow][newColumn] = distance + 1;
                }
            }
        }
        
        return -1;
    }
    
    private bool IsValid(int[][] grid, int row, int column)
    {
        if(row < 0 || column < 0 || row >= grid.Length || column >= grid[row].Length || grid[row][column] != 0)
            return false;
        
        return true;
    }
}