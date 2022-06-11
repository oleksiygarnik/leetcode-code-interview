public class Solution {
    public int[] SortArray(int[] nums) 
    {
        CountSort(nums);
        
        return nums;
    }
    
    private void BubbleSort(int[] nums)
    {
        for(int i = 0; i < nums.Length - 1; i++)
        {
            for(int j = 0; j < nums.Length - i - 1; j++)
            {
                if(nums[j] > nums[j + 1])
                {
                    var temp = nums[j + 1];
                    nums[j + 1] = nums[j];
                    nums[j] = temp;
                }
            }
        }
    }
    
    private void CountSort(int[] nums)
    {
        var min = nums.Min();
        var max = nums.Max();
        var range = max - min + 1;
        var count = new int[range];
        var output = new int[nums.Length];
        
        for(int i = 0; i < nums.Length; i++)
            count[nums[i] - min]++;
        
        for(int i = 1; i < count.Length; i++)
            count[i] += count[i - 1];
        
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            output[count[nums[i] - min] - 1] = nums[i];
            count[nums[i] - min]--;
        }
        
        for (int i = 0; i < nums.Length; i++) 
            nums[i] = output[i];
    }
}