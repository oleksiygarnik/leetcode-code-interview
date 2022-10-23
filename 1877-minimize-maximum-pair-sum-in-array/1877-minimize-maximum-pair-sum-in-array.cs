public class Solution {
    public int MinPairSum(int[] nums) 
    {
        QuickSort(nums, 0, nums.Length - 1);
        var left = 0;
        var right = nums.Length - 1;
        
        var maxValue = int.MinValue;
        while(left < right)
            maxValue = Math.Max(maxValue, nums[left++] + nums[right--]);
        
        return maxValue;
    }
    
    private int[] QuickSort(int[] array, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = array[leftIndex];
        
        while(i <= j)
        {
            while(array[i] < pivot)
                i++;
            
            while(array[j] > pivot)
                j--;
            
            if(i <= j)
            {
                var tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
                
                i++;
                j--;
            }
        }
        
        if(i < rightIndex)
            QuickSort(array, i, rightIndex);
        if(j > leftIndex)
            QuickSort(array, leftIndex, j);
        
        return array;
    }
}