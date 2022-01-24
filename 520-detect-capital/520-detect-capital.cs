public class Solution {
    public bool DetectCapitalUse(string word)
    {
        var count = word.Count(x => char.IsUpper(x));
        return count == word.Length 
            || count == 0 
            || (count == 1 && char.IsUpper(word[0]));
    }
}