public class Solution 
{
     public int MinimumTotal(IList<IList<int>> triangle) 
    {
        for(int i = triangle.Count() - 2; i >= 0; i--)
            for(int j = 0; j < triangle[i].Count(); j++)
                triangle[i][j] += Math.Min(triangle[i + 1][j], triangle[i + 1][j + 1]);
        
        return triangle[0][0];
    }
    
//     public int MinimumTotal(IList<IList<int>> triangle) 
//     {
//         var num = new int[triangle.Count() + 1];
//         for(int i = triangle.Count() - 1; i >= 0; i--)
//             for(int j = 0; j < triangle[i].Count(); j++)
//                 num[j] = Math.Min(num[j], num[j + 1]) + triangle[i][j];
        
//         return num[0];
//     }
    
//     public int MinimumTotal(IList<IList<int>> triangle) 
//     {
//         for(int i = 1; i < triangle.Count(); i++)
//         {
//             for(int j = 0; j < triangle[i].Count(); j++)
//             {
//                 if(j == 0)
//                     triangle[i][j] += triangle[i - 1][j];
//                 else if(j == triangle[i].Count() - 1)
//                     triangle[i][j] += triangle[i - 1][j - 1];
//                 else 
//                     triangle[i][j] += Math.Min(triangle[i - 1][j - 1], triangle[i - 1][j]);
//             }
//         }
        
//         return triangle[triangle.Count() - 1].Min();
//     }
}