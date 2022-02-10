public class Solution {
    public int SubarraySum(int[] nums, int k) {
         var sumStorage = new Dictionary<int, int>();
        sumStorage.Add(0, 1);
        
        int count = 0, sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            sum+=nums[i];
            if(sumStorage.ContainsKey(sum - k))
                count+=sumStorage[sum - k];
            
            if(sumStorage.ContainsKey(sum))
                sumStorage[sum]++;
            else
                sumStorage.Add(sum, 1);
        }
            
        return count;
    }
}