public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
            
            for(int i = 0; i < nums.Length; i++)
                dictionary[nums[i]] = i;

            for(int i = 0; i < nums.Length; i++)
            {
                int expected = target - nums[i];
                if (dictionary.ContainsKey(expected) && dictionary[expected] != i)
                    return new int[] { i, dictionary[expected] };
            }
        
            return new int[]{};
    }
}