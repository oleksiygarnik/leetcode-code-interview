public class Solution {
    public int MinFallingPathSum(int[][] matrix) 
    {
        int n = matrix.Length, m = matrix[0].Length;
        for(int i = n - 2; i >= 0; i--)
        {
           for(int j = 0; j < m; j++)
           {
               if(j == 0)
                   matrix[i][j] += Math.Min(matrix[i + 1][j], matrix[i + 1][j + 1]);
               else if(j == m - 1)
                   matrix[i][j] += Math.Min(matrix[i + 1][j], matrix[i + 1][j - 1]);
               else if(j > 0 && j < m)
                   matrix[i][j] += Math.Min(Math.Min(matrix[i + 1][j], matrix[i + 1][j - 1]), matrix[i + 1][j + 1]);
           }
        }
        
        return matrix[0].Min();
    }
}