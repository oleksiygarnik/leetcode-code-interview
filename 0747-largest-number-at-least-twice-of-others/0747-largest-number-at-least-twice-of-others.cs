public class Solution {
    public int DominantIndex(int[] nums) 
    {
        var copy = new int[nums.Length];
        Array.Copy(nums, copy, nums.Length);
        Array.Sort(nums);
        var largest = nums[nums.Length - 1];
        return (largest - nums[nums.Length - 2]) >= nums[nums.Length - 2]
            ? FindIndex(copy, largest) 
            : -1;
    }
    
    private int FindIndex(int[] nums, int largest)
    {
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == largest)
                return i;
        }
        
        return -1;
    }
}