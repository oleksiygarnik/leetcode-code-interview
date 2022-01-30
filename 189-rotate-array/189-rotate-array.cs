public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        
        int length = nums.Length;
        Reverse(nums, 0, length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, length - 1);
      
    }
    
    public void Reverse(int[] nums, int start, int end)
    {
        int j = end;
        for(int i = start; i <= j; i++)
        {
            if(i == j)
                break;
            
             var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
            j--;
        }
    }
}
















// var res1 = nums.AsSpan().Slice(0, k);
//         var res2 = nums.AsSpan().Slice(nums.Length - k - 1, k);
//         var res3 = nums.AsSpan().Slice(k, nums.Length - k - 1);
//         nums = res2.ToArray().Concat(res3.ToArray().Concat(res1.ToArray())).ToArray();