public class Solution {
    public IList<int> FindLonely(int[] nums) {
        var result = new List<int>();
        var dict = new Dictionary<int, int>();
        foreach(var num in nums)
        {
            if(dict.ContainsKey(num))
                dict[num]++;
            else
                dict.Add(num, 1);
        }
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i]))
            {
                if(dict[nums[i]] == 1 && !dict.ContainsKey(nums[i] - 1) &&  !dict.ContainsKey(nums[i] + 1))
                    result.Add(nums[i]);
            }
        }
        
        return result;
    }
}