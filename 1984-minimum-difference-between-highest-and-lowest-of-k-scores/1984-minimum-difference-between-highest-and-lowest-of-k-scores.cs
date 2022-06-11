public class Solution {
    public int MinimumDifference(int[] nums, int k) 
    {
        Array.Sort(nums);
        
        int left = 0, right = 0, result = int.MaxValue;
        while(right < nums.Length)
        {
            if(right - left + 1 == k)
            {
                result = Math.Min(result, nums[right] - nums[left]);
                left++;
            }
            
            right++;
        }
        
        return result;
    }
}