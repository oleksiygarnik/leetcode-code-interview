public class Solution {
    public long MaximumSubsequenceCount(string text, string pattern) 
    {
            long firstCount = 0, secondCount = 0, result = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == pattern[1])
                {
                    result += firstCount;
                    secondCount++;
                }
                
                  if (text[i] == pattern[0])
                    firstCount++;
            }

        return result + Math.Max(firstCount, secondCount);
    }
}