public class Solution {
    public bool RepeatedSubstringPattern(string s) 
    {
        int length = 1;
        while(length <= s.Length/2)
        {
            var prefix = s.Substring(0, length);
            if(IsValid(s, prefix))
                return true;
            
            length++;
        }
        
        return false;
    }
    
    private bool IsValid(string word, string prefix)
    {
        if(word.Length % prefix.Length > 0)
            return false;
        
        var startPrefix = prefix;
        while(prefix.Length <= word.Length)
        {
            if(prefix != word.Substring(0, prefix.Length))
                return false;

            prefix += startPrefix;
        }
        
        return true;
    }
}