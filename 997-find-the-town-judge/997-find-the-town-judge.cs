public class Solution {
    public int FindJudge(int n, int[][] trust) 
    {
        var dict = new Dictionary<int, int>();
        foreach(var person in Enumerable.Range(1, n))
            dict.Add(person, 0);
        
        foreach(var pair in trust)
        {
            if(dict.ContainsKey(pair[0]))
               dict.Remove(pair[0]);
               
            if(dict.TryGetValue(pair[1], out var res))
                dict[pair[1]] = ++res;
        }
               
        foreach(var keyValuePair in dict)
        {
            if(keyValuePair.Value == n - 1)
                return keyValuePair.Key;
        }
        
        return -1;
    }
}