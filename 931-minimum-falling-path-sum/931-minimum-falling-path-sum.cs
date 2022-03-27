public class Solution {
    public int MinFallingPathSum(int[][] matrix) 
    {
       for(int i = matrix.Length - 2; i >= 0; i--)
       {
           for(int j = 0; j < matrix[i].Length; j++)
           {
               if(j == 0)
                   matrix[i][j] += Math.Min(matrix[i + 1][j], matrix[i + 1][j + 1]);
               else if(j == matrix[i].Length - 1)
                   matrix[i][j] += Math.Min(matrix[i + 1][j], matrix[i + 1][j - 1]);
               else if(j > 0 && j < matrix[i].Length - 1)
                   matrix[i][j] += Math.Min(Math.Min(matrix[i + 1][j], matrix[i + 1][j - 1]), matrix[i + 1][j + 1]);
           }
       }
        
        return matrix[0].Min();
    }
}