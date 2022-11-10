public class Solution {
    public string RemoveDuplicates(string s) 
    {
        var stack = new Stack<char>();
        stack.Push(s[0]);
        
        for(int i = 1; i < s.Length; i++)
        {
            if(stack.Count() == 0)
            {
                stack.Push(s[i]);
                continue;
            }
            
            var prev = stack.Peek();
            if(prev == s[i])
                stack.Pop();
            else
                stack.Push(s[i]);
        }
        
        var result = "";
        while(stack.Count() > 0)
            result+= stack.Pop().ToString();
        
        return new string(result.Reverse().ToArray());
    }
}