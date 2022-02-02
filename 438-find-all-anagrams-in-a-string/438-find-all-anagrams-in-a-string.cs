public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        var arr1 = new int[26];
        for(int i = 0; i < p.Length; i++)
            arr1[p[i] - 'a']++;
        
        var result = new List<int>();
        var left = 0;
        var right = 0;
        var arr2 = new int[26];
        while(right < s.Length)
        {
            arr2[s[right] - 'a']++;
            if(right - left + 1 == p.Length)
            {
                if(arr1.SequenceEqual(arr2))
                    result.Add(left);
                
                arr2[s[left] - 'a']--;
                left++;
            }
            
            right++;
        }
        
        return result;
    }
}