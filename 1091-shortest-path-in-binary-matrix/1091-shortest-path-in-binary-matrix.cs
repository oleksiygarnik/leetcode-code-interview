public class Solution {
    private static int[] dRow = new int[]{ -1, -1, -1, 0, 0, 0, 1, 1, 1 };
    private static int[] dCol = new int[]{ -1, 0, 1, -1, 0, 1, -1, 0, 1 };
    
    public int ShortestPathBinaryMatrix(int[][] grid) {
        var length = grid.Length;
        
        if(grid[0][0] != 0 || grid[length - 1][length - 1] != 0)
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
                var adjx = row + dRow[i];
                var adjy = column + dCol[i];
                
                if(!IsValid(grid, adjx, adjy))
                    continue;
                
                queue.Enqueue(Tuple.Create(adjx, adjy));
                
                grid[adjx][adjy] = distance + 1;
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