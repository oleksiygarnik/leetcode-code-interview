public class Solution {
    public string ReversePrefix(string word, char ch) 
    {
        int i = 0;
        for(; i < word.Length; i++)
        {
            if(word[i] == ch)
                break;
        }
        
        if(i == word.Length)
            return word;
        
        var result = new StringBuilder();
        for(int j = i; j >= 0; j--)
            result.Append(word[j].ToString());
        
        for(int j = i + 1; j < word.Length; j++)
            result.Append(word[j].ToString());
        
        return result.ToString();
    }
}