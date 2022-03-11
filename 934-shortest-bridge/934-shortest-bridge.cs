public class Solution {
    
    private static int[] directionsRow = { 0, -1, 0, 1 };
    private static int[] directionsColumn = { -1, 0, 1, 0 };
    
    public int ShortestBridge(int[][] grid) 
    {
        var island = new List<Tuple<int, int>>();
        
        bool isFill = false;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] == 1)
                {
                    Dfs(grid, i, j, island);
                    isFill = true;
                    break;
                }
            }
            if(isFill)
                break;
        }
        
        var min = Int32.MaxValue;
        foreach(var keyValue in island)
            min = Math.Min(min, Bfs(grid, keyValue.Item1, keyValue.Item2));
        
        return min;
    }
    
    public void Dfs(int[][] grid, int row, int column, List<Tuple<int, int>> island)
    {
        if(grid[row][column] == 1)
        {
            grid[row][column] = 2;
            island.Add(Tuple.Create(row, column));
            
            if(row >= 1) Dfs(grid, row - 1, column, island);
            if(column >= 1) Dfs(grid, row, column - 1, island);
            if(row < grid.Length - 1) Dfs(grid, row + 1, column, island);
            if(column < grid[row].Length - 1) Dfs(grid, row, column + 1, island);
        }
    }
    
    public int Bfs(int[][] grid, int row1, int column1)
    {
        var height = grid.Length;
        var width = grid[0].Length;
        
        var visited = new bool[height, width];
        var queue = new Queue<Tuple<int, int, int>>();
        queue.Enqueue(Tuple.Create(row1, column1, 0));
        
        while(queue.Count() > 0)
        {
            var current = queue.Dequeue();
            
            var row = current.Item1;
            var column = current.Item2;
            var distance = current.Item3;
            
            visited[row, column] = true;
            if(grid[row][column] == 1)
                return distance - 1;
            
            distance++;
            for(int i = 0; i < 4; i++)
            {
                var newRow = row + directionsRow[i];
                var newColumn = column + directionsColumn[i];
                
                if(IsValid(grid, newRow, newColumn, visited))
                {
                    queue.Enqueue(Tuple.Create(newRow, newColumn, distance));
                    visited[newRow, newColumn] = true;
                }
            }    
        }
        
        return int.MaxValue;
    }
    
    private bool IsValid(int[][] grid, int row, int column, bool[,] visited)
    {
            var height = visited.GetUpperBound(0) + 1;
            var width = visited.Length / height;

            if (row < 0 || column < 0 || row > height - 1 || column > width - 1 || visited[row, column] || grid[row][column] == 2)
                return false;

            return true;
    }
}