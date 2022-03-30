public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        for(int i = 0; i < matrix.Length; i++)
        {
            var last = matrix[i].Length - 1;
            if(matrix[i][last] >= target)
                return Binary(matrix[i], 0, last, target);
        }
        
        return false;
    }
    
      private bool Binary(int[] nums, int left, int right, int target)
        {
            while(left <= right)
            {
                var middle = left + (right - left)/2;
                if(nums[middle] == target)
                    return true;
                
                if(nums[middle] > target)
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            
            return false;
        }
}