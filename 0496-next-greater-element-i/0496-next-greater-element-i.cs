public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) 
    {
        var stack = new Stack<int>();
        var dict = new Dictionary<int, int>();
        
        for(int i = 0; i < nums2.Length; i++)
        {
            while(stack.Count() > 0 && stack.Peek() < nums2[i])
                dict.Add(stack.Pop(), nums2[i]);
            
            stack.Push(nums2[i]);
        }
        
        for(int i = 0; i < nums1.Length; i++)
        {
            if(dict.ContainsKey(nums1[i]))
                nums1[i] = dict[nums1[i]];
            else
                nums1[i] = -1;
        }
        
        return nums1;
    }
}