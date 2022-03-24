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
        
        var n = prefixSum.Length;
        int odd = 0;
        int even = 0;
        var result = 0;
        for(int i = nums.Length - 1; i >= 1; i--)
        {
            if(i % 2 == 0)
            {
                var first = prefixSum[i] - nums[i] + odd;
                var second = prefixSum[i - 1] + even; 
              
                if(first == second)
                    result++;
                
                even += nums[i];
            }
            else
            {
                var first = prefixSum[i - 1] + odd;
                var second = prefixSum[i] - nums[i] + even;
                
                if(first == second)
                    result++;
                
                odd += nums[i];
            }
        }

        if(odd == even)
            result++;
        
        return result;
    }
}