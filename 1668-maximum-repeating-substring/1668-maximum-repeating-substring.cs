public class Solution {
    public int MaxRepeating(string sequence, string word) 
    {    
        int max = 0;
        int count = 0;
        int prev = 0;
        for(int i = 0; i <= sequence.Length - word.Length; i++)
        {
            int j = i;
            while(j <= sequence.Length - word.Length && sequence.Substring(j, word.Length) == word)
            {
                count++;
                max = Math.Max(max, count);
                j += word.Length;
            }
         
            count = 0;
        }
        
        return max;
    }
}