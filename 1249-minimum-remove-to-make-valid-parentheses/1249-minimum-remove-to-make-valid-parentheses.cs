public class Solution {
    public string MinRemoveToMakeValid(string s) 
    {
        var stack = new Stack<(char, int)>();
        var skip = new List<int>();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == ')')
            {
                if(stack.Count() == 0)
                    skip.Add(i);
                else
                    stack.Pop();
            }
            
            if(s[i] == '(')
                stack.Push(('(',i));
        }
        
        var sb = new StringBuilder();
        var skipList = stack.ToList().Select(x => x.Item2).ToList();
        
        var temp = skipList.Concat(skip).ToList();
        for(int i = 0; i < s.Length; i++)
        {
            if(temp.Contains(i))
                continue;
            
            sb.Append(s[i]);
        }
        
        return sb.ToString();
    }
}