public class Solution 
{
    public int TwoCitySchedCost(int[][] costs) 
    {
//         var priority = new (int, int)[costs.Length];
//         for(int i = 0; i < costs.Length; i++)
//             priority[i] = (costs[i][0] - costs[i][1], i);
        
//         Array.Sort(priority, (x, y) => x.Item1.CompareTo(y.Item1));
        
//         var result = 0;
//         for(int i = 0; i < costs.Length/2; i++)
//             result+=costs[priority[i].Item2][0] + costs[priority[i + costs.Length/2].Item2][1];
        
//         return result;
        
        Array.Sort(costs, new Comparer());
        
        var result = 0;
        for(int i = 0; i < costs.Length/2; i++)
            result += costs[i][0] + costs[i + costs.Length/2][1]; 
        
        return result;
    }
    
    public class Comparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y) => (x[0] - x[1]).CompareTo(y[0] - y[1]);
    }
}