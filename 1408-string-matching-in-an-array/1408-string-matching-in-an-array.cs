public class Solution {
    public IList<string> StringMatching(string[] words) {
        var result = new List<string>();
        for(int i = 0; i < words.Length; i++)
        {
            for(int j = 0; j < words.Length; j++)
            {
                if(i == j)
                    continue;
                
                if(words[i].Contains(words[j]))
                    result.Add(words[j]);
            }
        }
        
        return result.Distinct().ToList();
    }
}