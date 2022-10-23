public class Solution {
    public bool CheckIfExist(int[] arr) 
    {
        var dict = new Dictionary<int, List<int>>();
        for(int i = 0; i < arr.Length; i++)
        {
            if(dict.ContainsKey(arr[i] * 2))
                dict[arr[i] * 2].Add(i);
            else
                dict.Add(arr[i] * 2, new List<int>(){ i });
        }
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(dict.ContainsKey(arr[i]))
            {
                var possible = dict[arr[i]];
                if(possible.Any(x => x != i))
                    return true;
            }
        }
        
        return false;
    }
}