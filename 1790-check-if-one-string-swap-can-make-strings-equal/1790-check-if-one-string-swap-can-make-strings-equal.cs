public class Solution {
    public bool AreAlmostEqual(string s1, string s2) {
        if(s1 == s2)
            return true;
        
        int count = 0;
        var chars1 = new List<char>();
        var chars2 = new List<char>();
        for(int i = 0; i < s2.Length; i++)
        {
            if(s1[i] != s2[i])
            {
                chars1.Add(s1[i]);
                chars2.Add(s2[i]);
                count++;
            }
        }
        
        return count == 2 && chars1[0] == chars2[1] && chars1[1] == chars2[0] ? true : false;
    }
}