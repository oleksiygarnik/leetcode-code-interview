public class Solution {
    public bool IsMonotonic(int[] nums) 
    {
        if(nums.Length == 1)
            return true;

        var isIncreasing = nums[0] < nums[nums.Length - 1];
        
        for(int i = 0; i < nums.Length - 1; i++)
        {
            if(isIncreasing)
            {
                if(nums[i] > nums[i + 1])
                    return false;
            }
            else
            {
                if(nums[i] < nums[i + 1])
                    return false;
            }
        }
        
        return true;
    }
}