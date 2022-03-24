public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) 
    {
        var storage = new Dictionary<string, int>();
        for(int i = 0; i < words.Length; i++)
        {
            if(storage.ContainsKey(words[i]))
                storage[words[i]]+=1;
            else
                storage.Add(words[i], 1);
        }
        
        return storage.OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .Select(x => x.Key)
            .Take(k)
            .ToList();
    }
}