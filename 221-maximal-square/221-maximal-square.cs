public class Solution {
    public int MaximalSquare(char[][] matrix) 
    {
        var maxLength = 0;
        var dp = new int[matrix.Length + 1, matrix[0].Length + 1];
        for(int i = 1; i <= matrix.Length; i++)
        {
            for(int j = 1; j <= matrix[0].Length; j++)
            {
                if(matrix[i - 1][j - 1] == '1')
                {
                    dp[i,j] = Math.Min(Math.Min(dp[i,j - 1], dp[i - 1,j - 1]), dp[i - 1,j]) + 1;
                    maxLength = Math.Max(maxLength, dp[i,j]);
                }
            }
        }
        
        return maxLength * maxLength;
    }
}