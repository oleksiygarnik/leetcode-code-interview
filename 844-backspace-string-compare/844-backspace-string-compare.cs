public class Solution {
    public bool BackspaceCompare(string s, string t) {
        var stackS = new Stack<char>();
        var stackT = new Stack<char>();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '#')
            {
                if(stackS.Count != 0)
                    stackS.Pop();
            }
            else
                stackS.Push(s[i]);
        }
        
        for(int i = 0; i < t.Length; i++)
        {
            if(t[i] == '#')
            {
                if(stackT.Count != 0)
                    stackT.Pop();
            }
            else
                stackT.Push(t[i]);
        }
        
        string resultA = string.Empty;
        string resultB = string.Empty;
        while(stackT.Count != 0)
            resultA += stackT.Pop();
        
        while(stackS.Count != 0)
            resultB += stackS.Pop();
        
        return resultA == resultB;
    }
}