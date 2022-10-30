public class Solution {
    public int StrStr(string haystack, string needle) 
    {
        if(haystack.Length < needle.Length)
            return -1;
        
        int m = 100007;
        var prefixHash = 0;
        var textHash = 0;
        var h = 1;
        for(int i = 0; i < needle.Length; i++)
        {
            prefixHash = (prefixHash * 101 + needle[i]) % m;
            textHash = (textHash * 101 + haystack[i]) % m;
            if(i < needle.Length - 1)
                h = (h * 101) % m;
        }
        
        for(int i = 0; i < haystack.Length - needle.Length + 1; i++)
        {
            if(prefixHash == textHash)
            {
                if(haystack.Substring(i, needle.Length) == needle)
                    return i;
            }
            if(i<haystack.Length - needle.Length)
            {
                textHash = (101 * (textHash-(haystack[i]*h)) + haystack[i+needle.Length]) % m;
            }
            
            if(textHash<0) textHash+=m;
        }
        
        return -1;
    }
}