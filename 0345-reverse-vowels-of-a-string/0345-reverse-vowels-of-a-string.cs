public class Solution {
    public string ReverseVowels(string s) 
    {
        var indxs = new List<int>();
        var vowels = new char[]{ 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        
        for(int i = 0; i < s.Length; i++)
        {
            if(vowels.Contains(s[i]))
                indxs.Add(i);
        }
        
        var result = s.ToCharArray();
        var left = 0;
        var right = indxs.Count() - 1;
        while(left <= right)
        {
            var tmp = result[indxs[left]];
            result[indxs[left]] = result[indxs[right]];
            result[indxs[right]] = tmp;
            
            left++;
            right--;
        }
        
        return new string(result);
    }
}