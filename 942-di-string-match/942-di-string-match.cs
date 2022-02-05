public class Solution {
    public int[] DiStringMatch(string s) {
        var result = new List<int>();
        var left = 0;
        var right = s.Length;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'I')
            {
                result.Add(left);
                left++;
            }
            else
            {
                result.Add(right);
                right--;
            }
        }
        
        result.Add(left);
        
        return result.ToArray();
    }
}