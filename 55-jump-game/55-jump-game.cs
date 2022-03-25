public class Solution {
    public bool CanJump(int[] nums) 
    {
        var rch = 0;
        for(int i = 0; i <= rch; i++)
        {
            rch = Math.Max(rch, nums[i] + i);
            if(rch >= nums.Length - 1)
                return true;
        }
        
        return false;
    }
}