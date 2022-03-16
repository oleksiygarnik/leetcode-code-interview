public class Solution {
    public int DiagonalSum(int[][] mat) 
    {
        if(mat.Length == 1)
            return mat[0][0];
        
        int length = mat.Length;
        int sum = 0;
        for(int i = 0; i < length; i++)
        {
            sum += mat[i][i];
            
            var k = length - i - 1;
            sum+=mat[i][k];
        }
        
        return  length %2 == 0 ? sum : sum - mat[length/2][length/2];
    }
}