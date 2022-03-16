public class Solution {
    public int MaximalNetworkRank(int n, int[][] roads) 
    {
        var storage = new Dictionary<int, HashSet<int>>();
        
        for(int i = 0; i < n; i++)
            storage.Add(i, new HashSet<int>());
        
        for(int i = 0; i < roads.Length; i++)
        {
            storage[roads[i][0]].Add(roads[i][1]);
            storage[roads[i][1]].Add(roads[i][0]);
        }
        
        int max = int.MinValue;
        for(int i = 0; i < n - 1; i++)
        {
            for(int j = i + 1; j < n; j++)
            {
                var rank = storage[i].Count + storage[j].Count;
                
                if(storage[i].Contains(j))
                    rank--;
                
                max = Math.Max(max, rank);
            }
        }
        
        return max;
    }
}