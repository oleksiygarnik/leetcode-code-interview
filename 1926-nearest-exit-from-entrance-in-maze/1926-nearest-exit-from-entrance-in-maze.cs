public class Solution 
{
    public int NearestExit(char[][] maze, int[] entrance) 
    {
        var directionsRow = new int[]{ 0, -1, 0, 1 };
        var directionsColumn = new int[]{ -1, 0, 1, 0 };
        
        if(!IsExistsExit(maze))
            return -1;
        
        var queue = new Queue<Tuple<int, int>>();
        queue.Enqueue(Tuple.Create(entrance[0], entrance[1]));
        
        var visited = new int[maze.Length,maze[0].Length];
        visited[entrance[0], entrance[1]] = 0;
        maze[entrance[0]][entrance[1]] = '+';
        
        while(queue.Count() > 0)
        {
            var current = queue.Dequeue();
            
            var row = current.Item1;
            var column = current.Item2;
            var distance = visited[row, column];
                
            for(int i = 0; i < 4; i++)
            {
                var newRow = row + directionsRow[i];
                var newColumn = column + directionsColumn[i];
                
                if(IsValid(maze, newRow, newColumn))
                {
                    visited[newRow, newColumn] = distance + 1;
                    
                    if(IsExit(maze, newRow, newColumn))
                        return visited[newRow, newColumn];
                    
                    maze[newRow][newColumn] = '+';

                    queue.Enqueue(Tuple.Create(newRow, newColumn));
                }
            }
        }
        
        return -1;
    }
    
    private bool IsValid(char[][] maze, int row, int column)
    {
        if(row < 0 || column < 0 || row >= maze.Length || column >= maze[row].Length || maze[row][column] == '+')
            return false;
        
        return true;
    }
    
    private bool IsExit(char[][] maze, int row, int column)
    {
        if((row == 0 || column == 0 || row == maze.Length - 1 || column == maze[row].Length - 1) && maze[row][column] == '.')
            return true;
        
        return false;
    }
    
    private bool IsExistsExit(char[][] maze)
    {
        for(int i = 0; i < maze.Length; i++)
            if(maze[i][0] == '.' || maze[i][maze[i].Length - 1] == '.')
                return true;
        
        for(int i = 0; i < maze[0].Length; i++)
            if(maze[0][i] == '.' || maze[maze.Length - 1][i] == '.')
                return true;
        
        return false;
    }
}