public class Solution {
    public int GetLucky(string s, int k) {
        var transform = string.Empty;
        for(int i = 0; i < s.Length; i++)
            transform += (s[i] - 'a' + 1);
        
        while(k != 0)
        {
            transform = Transform(transform);
            k--;
        }
        
        return int.Parse(transform);
    }
    
    private string Transform(string s)
    {
        var result = 0;
        for(int i = 0; i < s.Length; i++)
            result += int.Parse(s[i].ToString());
        
        return result.ToString();
    }
}