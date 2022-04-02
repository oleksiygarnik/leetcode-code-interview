public class Solution {
    public bool ValidPalindrome(string s) {
        int start = 0;
        int end = s.Length - 1;
       while(start <= end)
       {
           if(s[start] != s[end])
               return IsEquals(start + 1, end, s) || IsEquals(start, end - 1, s);
           
           start++;
           end--;
        }
        
        return true;
    }
    
    private bool IsEquals(int start, int end, string s)
    {
        while(start <= end)
        {
            if(s[start] != s[end])
                return false;
            
            start++;
            end--;
        }
        
        return true;
    }
}