public class Solution {
    public int FindPairs(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        dict.Add(nums[0], 1);
        
        var result = 0;
        var repeat = new List<int>();
        for(int i = 1; i < nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i]))
            {
                if(k == 0)
                {
                    if(repeat.Contains(nums[i]))
                        continue;
                    
                    var keys = dict.Keys;
                foreach(var item in keys)
                {
                    if(Math.Abs(nums[i] - item) == k)
                        result++;
                    
                    repeat.Add(nums[i]);
                }
                }
            }
            else
            {
                var keys = dict.Keys;
                foreach(var item in keys)
                {
                    if(Math.Abs(nums[i] - item) == k)
                        result++;
                }
                
                dict.Add(nums[i], 1);
            }
        }
        
        return result;
    }
}