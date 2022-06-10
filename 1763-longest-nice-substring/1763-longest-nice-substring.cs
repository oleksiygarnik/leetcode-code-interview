public class Solution {
    public string LongestNiceSubstring(string s) 
    {
        var max = string.Empty;
        for(int i = 0; i < s.Length; i++)
        {
           for(int j = i; j < s.Length; j++)
           {
               var substring = s.Substring(i, j - i + 1);
               
               if(IsNice(substring))
               {
                   max = Math.Max(substring.Length, max.Length) == max.Length 
                       ? max 
                       : substring;
               }
            }
        }
        
        return max;
    }
    
    private bool IsNice(string s)
    {
        for(int i = 0; i < s.Length; i++)
        {
            if(Char.IsLower(s[i]))
            {
                if(!s.Contains(Char.ToUpper(s[i]).ToString()))
                    return false;
            }
            else
            {
                if(!s.Contains(Char.ToLower(s[i]).ToString()))
                    return false;
            }
        }
        
        return true;
    }
}