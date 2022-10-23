public class Solution {
    public string FindLongestWord(string s, IList<string> dictionary) 
    {
        var maxWord = string.Empty;
        var maxLength = int.MinValue;
        foreach(var word in dictionary.OrderBy(x => x))
        {
            if(IsSubsequence(word, s))
            {
               if(word.Length > maxLength)
               {
                   maxLength = word.Length;
                   maxWord = word;
               }
            }
        }
        
        return maxWord;
    }
    
    private bool IsSubsequence(string first, string second)
    {
        var left = 0;
        for(int i = 0; i < second.Length; i++)
        {
            if(first[left] == second[i])
            {
                left++;
                if(left == first.Length)
                    return true;
            }
        }            
        
        return false;
    }
}