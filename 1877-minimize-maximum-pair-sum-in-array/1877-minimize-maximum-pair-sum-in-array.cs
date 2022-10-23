public class Solution {
    public int MinPairSum(int[] nums) 
    {
        Array.Sort(nums);
        var left = 0;
        var right = nums.Length - 1;
        
        var maxValue = int.MinValue;
        while(left < right)
            maxValue = Math.Max(maxValue, nums[left++] + nums[right--]);
        
        return maxValue;
    }
}