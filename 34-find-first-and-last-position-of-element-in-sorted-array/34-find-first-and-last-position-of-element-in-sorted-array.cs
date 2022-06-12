public class Solution {
    public int[] SearchRange(int[] nums, int target) 
    {
        return BinarySearch(nums, target);
    }
    
    private int[] BinarySearch(int[] nums, int target)
    {
        if(nums.Length == 1)
        {
            if(nums[0] == target)
                return new[]{ 0, 0};
            else
                return new[]{ -1, -1 };
        }
        var result = new int[2];
        
        var index = int.MaxValue;
        int left = 0, right = nums.Length - 1;
        while(left <= right)
        {
            var middle = left + (right - left)/2;
            if(nums[middle] == target)
            {
                index = middle;
                break;
            }
            
            if(nums[middle] > target)
                right = middle - 1;
            else
                left = middle + 1;
        }
        
        if(index == int.MaxValue)
            return new []{ -1, -1}; 
        
        var temp = index;
        while(temp >= 0 && nums[temp] == target)
            temp--;
        
        result[0] = ++temp;
        
        while(index < nums.Length && nums[index] == target)
            index++;
        
        result[1] = --index;
        
        return result;
    }
}