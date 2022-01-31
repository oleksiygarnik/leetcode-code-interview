public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        var left = 0; 
        var right = nums.Length - 1;
        while(left <= right)
        {
            var middle = left + (right - left)/2;
            
            if(nums[middle] == target)
                return Find(nums, middle, target);
            
            if(nums[middle] > target)
                right = middle - 1;
            if(nums[middle] < target)
                left = middle + 1;
        }
        
        return new int[]{ -1, -1 };
    }
    
    private int[] Find(int[] nums, int middle, int target)
    {
        int min = middle;
        int max = middle;
        while(middle >= 0 && nums[middle] == target)
        {
            min = middle;
            middle--;
        }
        
        middle = max;
        while(middle < nums.Length && nums[middle] == target)
        {
            max = middle;
            middle++;
        }
        
        return new int[]{ min, max };
    }
}