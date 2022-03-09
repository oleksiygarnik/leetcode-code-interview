public class Solution {
    public string ArrangeWords(string text) {
        var buckets = new Dictionary<int, List<string>>();
        var words = text.Split(new char[]{ ' '});
        
        for(int i = 0; i < words.Length; i++)
        {
            var index = words[i].Length * words.Length;
            if(buckets.TryGetValue(index, out var res))
                res.Add(words[i].ToLowerInvariant());
            else
                buckets.Add(index, new List<string>() { words[i].ToLowerInvariant() });
        }
        
        var result = buckets.OrderBy(x => x.Key)
            .SelectMany(x => x.Value)
            .Aggregate((x, y) => $"{x} {y}");
        
        return result[0].ToString().ToUpperInvariant() +
            result.Substring(1, result.Length - 1);
    }
}