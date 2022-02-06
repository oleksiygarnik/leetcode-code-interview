public class Solution {
        public int RemoveDuplicates(int[] nums) {
        
      int len = nums.Length;
        if (len == 0)
            return 0;
        
        int i = 0;
        int count = 1;
        for (int j = 1; j < len; j++) {
            if (nums[i] == nums[j]) {
                if (count < 2) {
                    nums[++i] = nums[j];
                    count++;                    
                }
            } 
            else { 
                nums[++i] = nums[j]; 
                count = 1;
            }
        }
        return i+1;
    }
}