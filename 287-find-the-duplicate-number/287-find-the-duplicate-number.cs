public class Solution {
    public int FindDuplicate(int[] nums) {
        Array.Sort(nums);
        
        for(int i = 0; i < nums.Length - 1; i++)
        {
            if((nums[i] ^ nums[i + 1]) == 0)
                return nums[i];
        }
        
        return 1;
    }
}