public class Solution {
    private int[][] directions = new int[][] { new int []{ -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } };
    
    public bool Exist(char[][] board, string word) 
    {
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[i].Length; j++)
            {
                if(board[i][j] == word[0])
                {
                    var visited = new bool[board.Length,board[i].Length];
                    if(Dfs(board, i, j, word, 0, visited))
                        return true;
                }
            }
        }
        
        return false;
    }
    
    private bool Dfs(char[][] board, int row, int column, string word, int currentIndex, bool[,] visited)
    {
        if(currentIndex == word.Length - 1 && board[row][column] == word[currentIndex])
            return true;
        
        if(board[row][column] != word[currentIndex])
            return false;
        
        visited[row, column] = true;
        
        foreach(var dir in directions)
        {
            var newRow = row + dir[0];
            var newColumn = column + dir[1];
            
            if(IsValid(board, newRow, newColumn) && !visited[newRow, newColumn])
            {
                if(Dfs(board, newRow, newColumn, word, currentIndex + 1, visited))
                    return true;
                
                visited[newRow, newColumn] = false;
            }
        }
        
        return false;
    }
    
    private bool IsValid(char[][] board, int row, int column)
    {
          if(row < 0 || column < 0 || row >= board.Length || column >= board[row].Length)
            return false;
        
        return true;
    }
}