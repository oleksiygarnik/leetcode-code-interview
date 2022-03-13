public class Solution {
    public IList<int> FindKDistantIndices(int[] nums, int key, int k) {
        var result = new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if(nums[j] == key && Math.Abs(j - i) <= k)
                    result.Add(i);
            }
        }
        
        return result.Distinct().ToList();
    }
}