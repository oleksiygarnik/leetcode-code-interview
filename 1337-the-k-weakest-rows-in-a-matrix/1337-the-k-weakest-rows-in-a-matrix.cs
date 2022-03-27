public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) 
    {
        var arr = new Tuple<int,int>[mat.Length];
        for(int i = 0; i < mat.Length; i++)
        {
            var soldier = 0;
            for(int j = 0; j < mat[i].Length; j++)
            {
                if(mat[i][j] == 1)
                    soldier++;
            }
            
            arr[i] = Tuple.Create(soldier, i);
        }
        
        return arr.OrderBy(x => x.Item1)
            .ThenBy(x => x.Item2)
            .Take(k)
            .Select(x => x.Item2)
            .ToArray();
    }
}


























//         var dict = new Dictionary<int, int>();
//         for(int i = 0; i < mat.Length; i++)
//         {
//             int soldierCount = 0;
//             for(int j = 0; j < mat[i].Length; j++)
//             {
//                 if(mat[i][j] == 1)
//                     soldierCount++;
//                 else
//                     break;
//             }
            
//             dict.Add(i, soldierCount);
//         }
        
//         return dict.OrderBy(x => x.Value)
//             .ThenBy(x => x.Key)
//             .Select(x => x.Key)
//             .Take(k)
//             .ToArray();