public class Solution {
    public int ThreeSumClosest(int[] nums, int target) 
    {
        var closest = int.MaxValue;
        var result = 0;
        for(int i = 0; i < nums.Length - 2; i++)
        {
            for(int j = i + 1; j < nums.Length - 1; j++)
            {
                for(int k = j + 1; k < nums.Length; k++)
                {
                    var sum = nums[i] + nums[j] + nums[k];
                    if(closest > Math.Abs(target - sum))
                    {
                        result = sum;
                        closest = Math.Abs(target - sum);
                    }
                }
            }
        }
        
        return result;
    }
}