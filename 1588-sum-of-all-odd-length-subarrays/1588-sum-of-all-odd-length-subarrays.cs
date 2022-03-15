public class Solution {
    public int SumOddLengthSubarrays(int[] arr) {
        int result = 0;
        
        for(int i = 0; i < arr.Length - 1; i++)
        {
            int sum = arr[i];
            result += sum;
            for(int j = i + 1; j < arr.Length; j++)
            {
                sum += arr[j];
                if((j - i + 1)%2 == 1)
                    result += sum; 
            }
        }
        
        return result + arr[arr.Length - 1];
    }
}