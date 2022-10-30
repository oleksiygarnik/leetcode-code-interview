public class Solution {
    public bool RotateString(string s, string goal) 
    {
        return goal.Length == s.Length && (goal + goal).Contains(s);
    }
}