public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i]))
                dict[nums[i]]++;
            else
                dict.Add(nums[i], 1);
        }
        
        return dict.OrderByDescending(x => x.Value)
            .Select(x => x.Key)
            .Take(k)
            .ToArray();
    }
}