public class Solution {
    public IList<string> TwoEditWords(string[] queries, string[] dictionary) 
    {
        var result = new List<string>();
        foreach(var query in queries)
        {
            foreach(var dict in dictionary)
            {
                if(IsEditable(query, dict))
                {
                    result.Add(query);
                    break;
                }
            }
        }
        
        return result;
    }
    
    private bool IsEditable(string query, string word)
    {
        var count = 0;
        for(int i = 0; i < query.Length; i++)
        {
            if(query[i] != word[i])
                count++;
        }
        
        return count <= 2;
    }
}