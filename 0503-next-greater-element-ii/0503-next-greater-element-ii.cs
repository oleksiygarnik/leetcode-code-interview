public class Solution {
    public int[] NextGreaterElements(int[] nums) 
    {
        var copy = new int[nums.Length * 2];
        for(int i = 0; i < nums.Length; i++)
        {
            copy[i] = nums[i];
            copy[i + nums.Length] = nums[i];
        }
      
        var stack = new Stack<int>();
        var dict = new Dictionary<int, int>();
        for(int i = 0; i < copy.Length; i++)
        {
            while(stack.Count() > 0 && copy[stack.Peek()] < copy[i])
                dict.Add(stack.Pop(), copy[i]);
            
            stack.Push(i);
        }
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(i))
                nums[i] = dict[i];
            else
                nums[i] = -1;
        }
        
        return nums;
    }
}