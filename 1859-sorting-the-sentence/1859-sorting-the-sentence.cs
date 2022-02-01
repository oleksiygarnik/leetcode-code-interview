public class Solution {
    public string SortSentence(string s) {
        var words = s.Split(new char[]{ ' ' });
        var dict = new Dictionary<int, string>();
        for(int i = 0; i < words.Length; i++)
        {
            var key = int.Parse(words[i].Last().ToString());
            dict.Add(key, words[i].Substring(0, words[i].Length - 1));
        }
        
        return dict.OrderBy(x => x.Key).Select(x => x.Value).Aggregate((x, y) => $"{x} {y}");
    }
}