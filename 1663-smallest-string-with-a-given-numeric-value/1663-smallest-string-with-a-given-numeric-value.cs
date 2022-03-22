public class Solution {
    public string GetSmallestString(int n, int k) 
    {
        var currentCount = n;
        var result = new char[n];
        
        for(int i = 0; i < n; i++)
            result[i] = 'a';
        
        for(int i = result.Length - 1; i >= 0; i--)
        {
            if(currentCount == k)
                return new string(result);
            
            var num = k - currentCount + GetCharPosition(result[i]);
            
            var temp = GetCharPosition(result[i]);
            
            if(num >= 0 && num <= 26)
                result[i] = GetChar(num);
            else
                result[i] = GetChar(26);
            
            currentCount = currentCount - temp + GetCharPosition(result[i]);
        }
        
        return new string(result);
    }
        
    private char GetChar(int num) => (char)('a' - 1 + num);
    
    private int GetCharPosition(char ch) => ch - 'a' + 1;
}