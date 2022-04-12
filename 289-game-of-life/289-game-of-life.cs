public class Solution {
    int[] xMovements = {0,-1,-1,-1,0,1,1,1};
    int[] yMovements = {-1,-1,0,1,1,1,0,-1};
    public void GameOfLife(int[][] board) {
        int m = board.Length, n = board[0].Length;
        int[,] res = new int[m,n];
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n;j++)
            {
                int count = 0;
                for(int k =0 ;k < 8; k++)
                {
                    int xVar = i + xMovements[k];
                    int yVar = j + yMovements[k];
                    if(IsSafe(xVar,yVar,m,n))
                    {
                        count += (board[xVar][yVar] == 1?1:0);
                    }
                }
                
                res[i,j] = ApplyRule(board,i,j,count);
            }
        }
        
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n;j++)
            {
                board[i][j] = res[i,j];
            }
        }
    }
    
    bool IsSafe(int x, int y, int m, int n) {
        return x >=0 && y >= 0 && x < m && y < n;
    }
    
    int ApplyRule(int[][] board, int x, int y, int count) {
        if(count < 2) return 0;
        else if(count == 3) return 1;
        else if(count == 2) return board[x][y];
        else return 0;
    }
}