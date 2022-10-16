public class Solution {
    public int CountDistinctIntegers(int[] nums) 
    {
        var unique = new HashSet<int>();
        for(int i = 0; i < nums.Length; i++)
            unique.Add(nums[i]);
        
        for(int i = 0; i < nums.Length; i++)
        {
            var strValue = nums[i].ToString().Reverse();
            
            var val = string.Empty;
            foreach(var ch in strValue.SkipWhile(x => x == '0'))
                val += ch.ToString();
             
            var res = int.Parse(val);
            unique.Add(res);
        }
        
        return unique.Count();
    }
}