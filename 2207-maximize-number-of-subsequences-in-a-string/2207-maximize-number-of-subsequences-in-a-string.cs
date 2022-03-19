public class Solution {
    public long MaximumSubsequenceCount(string text, string pattern) 
    {
            long firstCount = 0;
            long secondCount = 0;
            long result = 0;
        
            var firstChar = pattern[0];
            var secondChar = pattern[1];
            for (int i = 0; i < text.Length; i++)
            {
                var current = text[i];
              
                if (current == secondChar)
                {
                    result += firstCount;
                    secondCount++;
                }
                
                  if (current == firstChar)
                    firstCount++;

            }

            if (firstCount <= secondCount)
                return result + secondCount;
            else
                return result + firstCount;
    }
}