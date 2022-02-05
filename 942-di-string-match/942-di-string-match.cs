public class Solution {
    public int[] DiStringMatch(string s) {
        var result = new List<int>();
        var numbers = Enumerable.Range(0, s.Length + 1).ToArray();
        var left = 0;
        var right = numbers.Length - 1;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'I')
            {
                result.Add(numbers[left]);
                left++;
            }
            
            if(s[i] == 'D')
            {
                result.Add(numbers[right]);
                right--;
            }
        }
        
        result.Add(numbers[left]);
        
        return result.ToArray();
    }
}