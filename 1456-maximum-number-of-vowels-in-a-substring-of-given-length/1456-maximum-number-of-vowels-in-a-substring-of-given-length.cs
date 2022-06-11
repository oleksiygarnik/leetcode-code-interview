public class Solution {
    public int MaxVowels(string s, int k) 
    {
        var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
        
        int max = 0;
        int current = 0;
        for(int i = 0; i < k; i++)
        {
            if(vowels.Contains(s[i]))
                current++;
        }
        
        max = Math.Max(max, current);
        
        for(int i = k; i < s.Length; i++)
        {
            if(vowels.Contains(s[i]))
                current++;
            
            if(vowels.Contains(s[i - k]))
               current--;
            
            max = Math.Max(max, current);
        }
        
        return max;
    }
}