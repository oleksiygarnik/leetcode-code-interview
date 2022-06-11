public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) 
    {
        int left = 0, right = 0, result = 0;
        
        while(right < arr.Length)
        {
            if(right - left + 1 == k)
            {
                int count = k;
                int j = left;
                int sum = 0;
                while(count != 0)
                {
                    sum += arr[j];
                    j++;
                    count--;
                }
                
                if(sum / k >= threshold)
                    result++;
                
                left++;
            }
            
            right++;
        }
        
        return result;
    }
}