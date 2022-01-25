public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length != t.Length)
            return false;
        
        var arr = new int[26];
        for(int i = 0; i < s.Length; i++)
            arr[s[i] - 'a']++;
        
        for(int i = 0; i < t.Length; i++)
        {
            arr[t[i] - 'a']--;
            if(arr[t[i] - 'a'] < 0)
                return false;
        }
        
        return true;
    }
}