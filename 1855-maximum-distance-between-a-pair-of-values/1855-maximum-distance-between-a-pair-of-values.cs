public class Solution {
    
    private int BinarySearch(int target, int[] nums, int left)
    {
        int val = -1;
        int right = nums.Length - 1;
        while(left <= right)
        {
            var middle = left + (right - left)/2;
            
            if(nums[middle] >= target)
            {
                val = middle;
                left = middle + 1;
            }
            else
                right = middle - 1;
           
        }
        
        return val;
    }
    
    public int MaxDistance(int[] nums1, int[] nums2) {
        var maxDistance = 0;
        for(int i = 0; i < nums1.Length; i++)
        {
            if(i < nums2.Length)
                maxDistance = Math.Max(maxDistance, BinarySearch(nums1[i], nums2, i) - i);
        }
        
        return maxDistance;
        

        
//         var maxDistance = 0;
//         for(int j = nums2.Length - 1; j >= 0; j--)
//         {
//             for(int i = 0; i < nums1.Length && i <= j; i++)
//             {
//                 if(j >= i && nums2[j] >= nums1[i])
//                     return j - i;
//             }
//         }
        
//         return maxDistance;
    }
}