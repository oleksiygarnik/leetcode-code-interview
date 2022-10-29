public class Solution {
    public int DestroyTargets(int[] nums, int space) 
    {
        var dict = new Dictionary<int, (int, int)>();
        foreach(var num in nums)
        {
            var mod = num % space;
            if(dict.ContainsKey(mod))
                dict[mod] = (dict[mod].Item1 + 1, Math.Min(dict[mod].Item2, num));
            else
                dict.Add(mod, (1, num));
        }
        
        int resultValue = nums[0];
        int resultCounter = 1;

        foreach (var value in dict.Values)
        {
            if (value.Item1 > resultCounter || (value.Item1 == resultCounter && value.Item2 < resultValue))
            {
                resultCounter = value.Item1;
                resultValue = value.Item2;
            }
        }
        return resultValue;
    }
}