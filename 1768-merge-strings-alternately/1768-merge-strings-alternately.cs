public class Solution {
    public string MergeAlternately(string word1, string word2) 
    {
        var left = 0;
        var right = 0;
        
        var sb = new StringBuilder();
        
        while(left < word1.Length && right < word2.Length)
        {
            sb.Append(word1[left++]);
            sb.Append(word2[right++]);
        }
        
        if(left == word1.Length)
            sb.Append(word2.Substring(right, word2.Length - right));
        
        if(right == word2.Length)
            sb.Append(word1.Substring(left, word1.Length - left));
        
        return sb.ToString();
    }
}