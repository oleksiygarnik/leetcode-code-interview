public class Solution {
    public bool CheckIfExist(int[] arr) 
    {
        Array.Sort(arr);
        for(int i = 0; i < arr.Length; i++)
        {
            var answer = BinarySearch(arr, arr[i] * 2, i);
            if(answer != -1)
                return true;
        }
        
        return false;
    }
    
    private int BinarySearch(int[] arr, int target, int currentIndex)
    {
        var left = 0;
        var right = arr.Length - 1;
        while(left <= right)
        {
            var mid = left + (right - left)/2;
            if(target == arr[mid] && currentIndex != mid)
                return mid;
            
            if(arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        
        return -1;
    }
}