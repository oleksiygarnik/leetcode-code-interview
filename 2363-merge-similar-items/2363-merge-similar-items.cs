public class Solution {
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2) 
    {
        var dict = new Dictionary<int, int>();
        for(int i = 0; i < items1.Length; i++)
            dict.Add(items1[i][0], items1[i][1]);
        
        for(int j = 0; j < items2.Length; j++)
        {
            if(dict.ContainsKey(items2[j][0]))
                dict[items2[j][0]]+= items2[j][1];
            else
                dict.Add(items2[j][0], items2[j][1]);
        }
        
        return dict.OrderBy(x => x.Key)
            .Select(x => new List<int>{ x.Key, x.Value })
            .Cast<IList<int>>()
            .ToList();
    }
}