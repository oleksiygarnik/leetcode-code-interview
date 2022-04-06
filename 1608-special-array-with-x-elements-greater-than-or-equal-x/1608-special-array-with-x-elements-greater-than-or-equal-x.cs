public class Solution {
    public int SpecialArray(int[] nums)
    {
        var arr = Enumerable.Range(0, nums.Length + 1).ToArray();
        for(int i = 0; i < arr.Length; i++)
        {
            int res = 0;
            for(int j = 0; j < nums.Length; j++)
            {
                if(nums[j] >= i)
                    res++;
                
                if(res > i)
                {
                    res = int.MaxValue;
                    break;
                }
            }
            
            if(i == res)
                return i;
        }
        
        return -1;
    }
}