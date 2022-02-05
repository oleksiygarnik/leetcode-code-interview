public class Solution {
    public int[] DiStringMatch(string s) {
        var result = new List<int>();
        var numbers = Enumerable.Range(0, s.Length + 1).ToList();
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'I')
            {
                result.Add(numbers.First());
                numbers = numbers.Skip(1).ToList();
            }
            
            if(s[i] == 'D')
            {
                result.Add(numbers.Last());
                numbers = numbers.Take(numbers.Count() - 1).ToList();
            }
        }
        
        result.Add(numbers.First());
        
        return result.ToArray();
    }
}