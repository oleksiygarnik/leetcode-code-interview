public class Solution {
    public char FindTheDifference(string s, string t) 
    {
        s = new string(s.OrderBy(x => x).ToArray());
        t = new string(t.OrderBy(x => x).ToArray());
        if(s.Length == 0)
            return t[0];
        
        for(int i = 0; i < s.Length; i++)
        {
            if(t[i] != s[i])
                return t[i];
        }
        
        return t[t.Length - 1];
    }
}