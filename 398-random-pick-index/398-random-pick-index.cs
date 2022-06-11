public class Solution {

    private readonly Dictionary<int, List<int>> _randomizer;
    
    public Solution(int[] nums) 
    {
        _randomizer = new Dictionary<int, List<int>>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(_randomizer.ContainsKey(nums[i]))
                _randomizer[nums[i]].Add(i);
            else
                _randomizer.Add(nums[i], new List<int>() { i });
        }
    }
    
    public int Pick(int target) 
    {
        var possible = _randomizer[target];
        
        var rnd = new Random();
        
        return possible[rnd.Next(0, possible.Count())];
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */