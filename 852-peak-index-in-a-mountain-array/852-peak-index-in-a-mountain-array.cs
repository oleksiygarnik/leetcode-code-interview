public class Solution {
    public int PeakIndexInMountainArray(int[] arr) 
    {
        int left = 1, right = arr.Length - 2;
        while(left <= right)
        {
            var middle = left + (right - left)/2;
            if(arr[middle] > arr[middle - 1] && arr[middle] > arr[middle + 1])
                return middle;
            
            if(arr[middle] < arr[middle + 1])
                left = middle + 1;
            else
                right = middle - 1;
        }
        
        return left;
    }
}