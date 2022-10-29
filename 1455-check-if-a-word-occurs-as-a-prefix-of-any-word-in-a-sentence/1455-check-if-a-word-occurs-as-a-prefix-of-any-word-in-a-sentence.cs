public class Solution {
    public int IsPrefixOfWord(string sentence, string searchWord) 
    {
        var words = sentence.Split(new[]{ ' ' });
        for(int i = 0; i < words.Length; i++)
        {
            if(IsPrefix(words[i], searchWord))
                return i + 1;
        }
        
        return -1;
    }
    
    private bool IsPrefix(string word, string prefix)
    {
        if(word.Length < prefix.Length)
            return false;
        
        for(int i = 0; i < prefix.Length; i++)
        {
            if(word[i] != prefix[i])
                return false;
        }
        
        return true;
    }
}