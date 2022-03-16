public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        var result = new int[r][];
        for(int i = 0; i < r; i++)
            result[i] = new int[c];
        
        var lengthX = mat.Length;
        var lengthY = mat[0].Length;
        
        if(lengthX * lengthY != r * c)
             return mat;
            
        int x = 0, y = 0;
        for(int i = 0; i < r; i++)
        {
            for(int j = 0; j < c; j++)
            {
                if(y >= lengthY)
                {
                    x++;
                    if(x >= lengthX)
                        return mat;
                    
                    y = 0;
                }
                result[i][j] = mat[x][y];
                y++;
            }
        }
        
        return result;
    }   
}