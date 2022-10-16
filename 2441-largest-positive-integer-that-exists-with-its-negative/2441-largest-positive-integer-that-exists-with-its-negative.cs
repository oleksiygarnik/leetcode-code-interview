public class Solution {
    public int FindMaxK(int[] nums) 
    {
        Array.Sort(nums);
        var left = 0;
        var right = nums.Length - 1;
        
        while(left <= right)
        {
            var num = nums[left] + nums[right];
            if(num == 0)
                return nums[right];
            
            if(num > 0)
                right--;
            else
                left++;
        }

        return -1;
    }
}