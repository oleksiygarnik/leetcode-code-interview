public class Solution {
    public int WaysToMakeFair(int[] nums) 
    {
        if(nums.Length == 1)
            return 1;
        if(nums.Length == 2)
            return 0;
        
        var prefixSum = new int[nums.Length];
        prefixSum[0] = nums[0];
        prefixSum[1] = nums[1];
        
        for(int i = 2; i < nums.Length; i++)
            prefixSum[i] = prefixSum[i - 2] + nums[i];
        
        int odd = 0;
        int even = 0;
        var result = 0;
        for(int i = nums.Length - 1; i >= 1; i--)
        {
            int first, second = 0; 
            if(i % 2 == 0)
            {
                first = prefixSum[i] - nums[i] + odd;
                second = prefixSum[i - 1] + even; 
                
                even += nums[i];
            }
            else
            {
                first = prefixSum[i - 1] + odd;
                second = prefixSum[i] - nums[i] + even;
                
                odd += nums[i];
            }
            
             if(first == second)
                 result++;
        }

        if(odd == even)
            result++;
        
        return result;
    }
}