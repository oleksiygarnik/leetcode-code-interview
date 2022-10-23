public class Solution {
    public long MinimalKSum(int[] nums, int k) 
    {
        long sum = 0;
        Array.Sort(nums);
        
        var item = 1;
        while(item != nums[0])
        {
            sum += item;
            item++;
            k--;
            
             if(k == 0)
                 return sum;
        }
        
        for(int i = 0; i < nums.Length - 1; i++)
        {
            if(nums[i + 1] - nums[i] != 1)
                sum += GenerateSum(nums[i], nums[i + 1], ref k);
        }

        long last = nums[nums.Length - 1];
        while(k != 0)
        {
            last++;
            sum += last;
            k--;
        }
        
        return sum;
    }
    
    private long GenerateSum(int val1, int val2, ref int k)
    {
        long sum = 0;
        if(val2 - val1 == 0)
            return 0;
            
        while((val2 - val1)!= 1 && k != 0)
        {
            val1++;
            sum += val1;
            k--;
        }
        
        return sum;
    }
}