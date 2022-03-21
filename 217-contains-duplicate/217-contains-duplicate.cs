public class Solution {
    public bool ContainsDuplicate(int[] nums) => 
        new HashSet<int>(nums).Count() < nums.Length;
}