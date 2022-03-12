public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        
        var distance = new int[mat.Length][];
        for(int i = 0; i < mat.Length; i++)
        {
            distance[i] = new int[mat[i].Length];
            Array.Fill(distance[i], int.MaxValue - 100000);
        }
        
        for(int i = 0; i < mat.Length; i++)
        {
            for(int j = 0;  j < mat[i].Length; j++)
            {
                if(mat[i][j] == 0)
                    distance[i][j] = 0;
                else
                {
                    if(i > 0)
                        distance[i][j] = Math.Min(distance[i][j], distance[i - 1][j] + 1);
                    if(j > 0)
                        distance[i][j] = Math.Min(distance[i][j], distance[i][j - 1] + 1);
                }
            }
        }
        
        for(int i = mat.Length - 1; i >= 0; i--)
        {
            for(int j = mat[i].Length - 1;  j >= 0; j--)
            {
              
                    if(i < mat.Length - 1)
                        distance[i][j] = Math.Min(distance[i][j], distance[i + 1][j] + 1);
                    if(j < mat[i].Length - 1)
                        distance[i][j] = Math.Min(distance[i][j], distance[i][j + 1] + 1);
                
            }
        }
        
        return distance;
      
        
//         var distance = new int[mat.Length][];
//         for(int i = 0; i < mat.Length; i++)
//             distance[i] = new int[mat[i].Length];
        
//         for(int i = 0; i < mat.Length; i++)
//         {
//             for(int j = 0; j < mat[i].Length; j++)
//             {
//                 if(mat[i][j] == 1)
//                 {
//                     Bfs(mat, i, j);
//                 }
//             }
//         }
        
//         return distance;
    }
    
    // private bool Bfs(int[][] mat, int row, int column)
    // {
    //     return true;
    // }
}