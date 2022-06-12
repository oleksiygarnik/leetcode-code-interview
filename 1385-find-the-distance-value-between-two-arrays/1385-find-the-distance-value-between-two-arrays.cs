public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) 
    {
        var result = 0;
        for(int i = 0; i < arr1.Length; i++)
        {
            bool isValue = true;
            for(int j = 0; j < arr2.Length; j++)
            {
                if(Math.Abs(arr1[i] - arr2[j]) <= d)
                {
                    isValue = false;
                    break;
                }
            }
            
            if(isValue)
                result++;
        }
        
        return result;
    }
}