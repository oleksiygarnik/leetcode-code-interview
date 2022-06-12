public class Solution {
    public char NextGreatestLetter(char[] letters, char target) 
    {
        foreach(var ch in letters)
        {
            if(ch > target)
                return ch;
        }
        
        return letters[0];
    }
}