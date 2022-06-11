public class Solution {
    public int LongestSubarray(int[] nums) 
    {
        int left = 0, right = 0, result = 0;
        int current = 0;
        while(right < nums.Length)
        {
            if(nums[right] == 1)
                current++;
            
            if(right - left + 1 - current <= 1)
            {
                result = Math.Max(result, current);
            }
            else
            {
                if(nums[left] == 1)
                    current--;

                left++;
            }
            
            right++;
        }
        
        return nums.All(x => x == 1) ? result - 1 : result;
    }
}