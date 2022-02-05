public class Solution {
    public int[] DiStringMatch(string s) {
        var result = new int[s.Length + 1];
        var left = 0;
        var right = s.Length;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'I')
                result[i] = left++;
            else
                result[i] = right--;
        }
        
        result[s.Length] = left;
        
        return result;
    }
}