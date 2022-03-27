public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) 
    {
        var pq = new PriorityQueue<int, Tuple<int, int>>(new Comparer());
        
        for(int i = 0; i < mat.Length; i++)
            pq.Enqueue(i, Tuple.Create(BinarySearch(mat[i]), i));
        
        var res = new int[k];
        for(int i = 0; i < k; i++)
            res[i] = pq.Dequeue();
        
        return res;
    }
    
    private int BinarySearch(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        while(left <= right)
        {
            var middle = left + (right - left)/2;
            if(arr[middle] == 1)
                left = middle + 1;
            else
                right = middle - 1;
        }
        
        return right + 1;
        
    }
    public class Comparer : IComparer<Tuple<int, int>>
    {
        public int Compare(Tuple<int,int> x, Tuple<int,int> y)
        {
            if(x.Item1 < y.Item1 || (x.Item1 == y.Item1 && x.Item2 < y.Item2)) 
                return -1;
            
            return 1;
        }
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