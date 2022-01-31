public class Solution {
    public void DuplicateZeros(int[] arr) {
        int i = 0;

        while(i < arr.Length)
        {
            if(arr[i] == 0)
            {
                for(int j = arr.Length - 1; j > i + 1; j--)
                    arr[j] = arr[j - 1];
                
                i++;
                
                if(i == arr.Length)
                    return;
                
                arr[i] = 0;
            }
            
            i++;
        }
    }
}