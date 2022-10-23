public class Solution {
    public int MinMoves2(int[] nums) 
    {
        Array.Sort(nums);
        
        var pivot = nums[nums.Length / 2];
        var result = 0;
        for(int i = 0; i < nums.Length; i++)
            result += Math.Abs(pivot - nums[i]);
        
        return result;
    }
}