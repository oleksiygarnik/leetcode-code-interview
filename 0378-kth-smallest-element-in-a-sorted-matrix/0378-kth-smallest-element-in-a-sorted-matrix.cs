public class Solution {
    public int KthSmallest(int[][] matrix, int k) 
    {
        var arr = new int[matrix.Length * matrix.Length];
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[0].Length; j++)
            {
                arr[i * matrix.Length + j] = matrix[i][j];
            }
        }
        
        Array.Sort(arr);
        return arr[k - 1];
    }
}