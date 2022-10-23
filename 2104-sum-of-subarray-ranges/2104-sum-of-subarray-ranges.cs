public class Solution {
    public long SubArrayRanges(int[] nums) 
    {
        long sum = 0;
         for(int i = 0; i < nums.Length; i++)
         {
             var min = int.MaxValue;
             var max = int.MinValue;
             for(int j = i; j < nums.Length; j++)
             {
                 min = Math.Min(min, nums[j]);
                 max = Math.Max(max, nums[j]);
                 
                 sum += (max - min);
             }
         }
        
        return sum;
    }
}