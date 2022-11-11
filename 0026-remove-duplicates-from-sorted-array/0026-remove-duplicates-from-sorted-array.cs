public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        var curr = nums[0];
        var index = 1;
        int count = 1;
        for(int i = 1; i < nums.Length; i++)
        {
            if(curr == nums[i])
                continue;
            else
            {
                curr = nums[i];
                nums[index] = nums[i];
                index++;
                count++;
            }
        }
        
        return count;
    }
}