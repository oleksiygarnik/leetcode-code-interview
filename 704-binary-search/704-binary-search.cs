public class Solution {
    public int Search(int[] nums, int target) 
    {
        int left = 0;
        int right = nums.Length - 1;
        int middle = 0;
        while(left <= right)
        {
            middle = left + (right - left)/2;
            if(nums[middle] == target)
                return middle;
            else if(nums[middle] > target)
                right = middle - 1;
            else 
                left = middle + 1;
        }
        
        return -1;
    }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
//         {
//         return BinarySearch(nums, 0, nums.Length - 1, target);
//     }
    
//     public int BinarySearch(int[] nums, int left, int right, int target)
//     {
//         if(right >= left)
//         {
//         var middle = left + (right - left)/2;
        
//         if(nums[middle] == target)
//             return middle;
//         if(nums[middle] < target)
//             return BinarySearch(nums, middle + 1, right, target);
//         else
//             return BinarySearch(nums, left, middle - 1, target);
//         }
        
//         return -1;
//     }
}