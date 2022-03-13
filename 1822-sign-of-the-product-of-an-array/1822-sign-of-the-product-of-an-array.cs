public class Solution {
    public int ArraySign(int[] nums)
    {
        var count = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
                return 0;
            
            if(nums[i] < 0)
                count++;
        }
        
        return count % 2 == 0 ? 1 : -1;
    }
}