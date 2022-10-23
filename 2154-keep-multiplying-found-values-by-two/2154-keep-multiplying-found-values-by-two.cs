public class Solution {
    public int FindFinalValue(int[] nums, int original) 
    {
        Array.Sort(nums);
        for(int i = 0; i < nums.Length; i++)
        {
            if(BinarySearch(nums, i, nums.Length - 1, original) != -1)
                original *= 2;
        }
        
        return original;
    }
    
    private int BinarySearch(int[] arr, int left, int right, int original)
    {
        while(left <= right)
        {
            var mid = left + (right - left)/2;
            if(arr[mid] == original)
                return mid;
            
            if(arr[mid] < original)
                left = mid + 1;
            else
                right = mid - 1;
        }
        
        return - 1;
    }
}