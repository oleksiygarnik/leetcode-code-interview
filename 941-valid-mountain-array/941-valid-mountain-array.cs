public class Solution {
    public bool ValidMountainArray(int[] arr) 
    {
        if(arr.Length <= 2)
            return false;
        
        bool isDecreasing = false;
        for(int i = 1; i < arr.Length; i++)
        {
            if(isDecreasing)
            {
                if(arr[i - 1] <= arr[i])
                    return false;
            }
            else
            {
                if(arr[i - 1] > arr[i]){
                    if(i == 1)
                        return false;
                    isDecreasing = true;
                    continue;
                }
                
                if(arr[i - 1] >= arr[i])
                    return false;
            }
        }
        
        return isDecreasing == false ? false : true;
    }
}