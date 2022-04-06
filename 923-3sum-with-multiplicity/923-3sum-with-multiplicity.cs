public class Solution {
    public int ThreeSumMulti(int[] arr, int target) 
    {
        long result = 0;
        for(int i = 0; i < arr.Length - 2; i++)
        {
            var newTarget = target - arr[i];
            result += TwoSum(arr, newTarget, i + 1);
            result %= (int)Math.Pow(10,9) + 7;
        }
        
        return (int)result;
    }
    
    public int TwoSum(int[] arr, int target, int startIndex)
    {
        var visited = new Dictionary<int, int>();
        int result = 0;
        
        for(int i = startIndex; i < arr.Length; i++)
        {
            var newTarget = target - arr[i];
            if(visited.ContainsKey(newTarget))
                result += visited[newTarget];
            
            if(!visited.ContainsKey(arr[i]))
                visited.Add(arr[i], 1);
            else
                visited[arr[i]]++;
        }
        
        return result;
    }
}