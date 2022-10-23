public class Solution {
    public int FindFinalValue(int[] nums, int original) 
    {
        QuickSort(nums, 0, nums.Length - 1);
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
    
    private int[] QuickSort(int[] nums, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = nums[leftIndex];
        
        while(i <= j)
        {
            while(nums[i] < pivot)
                i++;
            while(nums[j] > pivot)
                j--;
            
            if(i <= j)
            {
                var tmp = nums[i];
                nums[i] = nums[j];
                nums[j] = tmp;
                
                i++;
                j--;
            }
        }
        
        if(i < rightIndex)
            QuickSort(nums, i, rightIndex);
        if(j > leftIndex)
            QuickSort(nums, leftIndex, j);
        
        return nums;
    }
}