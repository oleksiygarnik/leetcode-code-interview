public class Solution {
    public int MinimumMoves(string s) {
        int result = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'X')
            {
                result++;
                i+=2;
            }
        }
        
        return result;
    }
}