public class Solution {
    public int FindFinalValue(int[] nums, int original) 
    {
        var set = new HashSet<int>(nums);
        while(set.Contains(original))
            original *= 2;
        
        return original;
    }
}