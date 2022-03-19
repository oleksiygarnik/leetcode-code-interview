public class Solution {
    public bool IsAlienSorted(string[] words, string order) 
    {
        var dict = new Dictionary<char, int>();
        for(int i = 0; i < order.Length; i++)
            dict.Add(order[i], i);
        
        for(int i = 0; i < words.Length - 1; i++)
        {
            var min = Math.Min(words[i].Length, words[i + 1].Length);
            var isEqual = false;
            
            for(int j = 0; j < min; j++)
            {
                if(dict[words[i][j]] > dict[words[i + 1][j]])
                    return false;
                
                 if(dict[words[i][j]] < dict[words[i + 1][j]])
                 {
                    isEqual = false;
                    break;
                 }
                
                if(dict[words[i][j]] == dict[words[i + 1][j]])
                    isEqual = true;
                else
                    isEqual = false;
            }
            
            if(isEqual && words[i].Length > words[i + 1].Length)
                return false;
        }
        
        return true;
    }
}