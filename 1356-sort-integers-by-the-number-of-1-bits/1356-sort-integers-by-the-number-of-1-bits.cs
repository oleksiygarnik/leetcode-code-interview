public class Solution {
    public int[] SortByBits(int[] arr) 
    {
        return arr.Select(x => (value : x, count: Convert.ToString(x, 2).Count(c => c == '1')))
            .OrderBy(x => x.count)
            .ThenBy(x => x.value)
            .Select(x => x.value)
            .ToArray();
    }
}