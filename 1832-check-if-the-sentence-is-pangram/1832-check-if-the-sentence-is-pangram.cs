public class Solution {
    public bool CheckIfPangram(string sentence) 
    {
        var dict = new Dictionary<char, int>();
        var alphabet = "abcdefghijklmnopqrstuvwxyz";
        foreach(var ch in alphabet)
            dict.Add(ch, 1);
        
        foreach(var ch in sentence)
            dict[ch]--;
        
        return !dict.Values.Any(x => x == 1);
    }
}