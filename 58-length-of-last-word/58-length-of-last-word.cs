public class Solution {
    public int LengthOfLastWord(string s) 
    {
       return s.Split(' ').Where(x => x != string.Empty).Last().Length;
    }
}